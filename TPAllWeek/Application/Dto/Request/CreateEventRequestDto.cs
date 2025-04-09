using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Application.Dto.Request;

public class CreateEventRequestDto
{
    [Required]
    [StringLength(64)]
    public required string Title { get; set; }
    [StringLength(1024)]
    public string? Description { get; set; }
    [Required]
    public required DateOnly StartDate { get; set; }
    [Required]
    public required DateOnly EndDate { get; set; }
    [Required]
    public required EventStatus Status { get; set; }
    [Required]
    public int? CategoryId { get; set; }
    [Required]
    public int? LocationId { get; set; }
}