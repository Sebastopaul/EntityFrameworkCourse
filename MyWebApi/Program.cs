using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyWebApi;
using MyWebApi.Interceptors;
using MyWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

var app = builder.Build();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    if (!options.IsConfigured)
    {
        if (app.Environment.IsDevelopment())
        {
            options.EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableDetailedErrors();
        }

        options.UseSqlServer(builder.Configuration.GetConnectionString("Isitech"))
            .AddInterceptors(new TaggedQueryCommandInterceptor())
            .UseAsyncSeeding(async (context, _, cancellationToken) =>
            {
                var testCategory = await context.Set<Category>().FirstOrDefaultAsync(b => b.Name == "test", cancellationToken);
                if (testCategory == null)
                {
                    context.Set<Category>().Add(new Category { Name = "test" });
                    await context.SaveChangesAsync(cancellationToken);
                }
            });;
    }
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
