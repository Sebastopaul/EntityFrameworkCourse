using AutoMapper;
using TPAllWeek.Application.Dto.Request;
using TPAllWeek.Application.Dto.Response;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Application.Mapper;

public class EventProfile : Profile
{
    public EventProfile()
    {
        CreateMap<CreateEventRequestDto, Event>();
        CreateMap<UpdateEventRequestDto, Event>();
        CreateMap<Event, EventResponse>();
    }
}