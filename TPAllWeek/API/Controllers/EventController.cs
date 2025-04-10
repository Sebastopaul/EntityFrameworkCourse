using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TPAllWeek.Application.Dto.Request;
using TPAllWeek.Application.Dto.Response;
using TPAllWeek.Application.Services;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.API.Controllers;

[Route("[controller]")]
public class EventController : ControllerBase
{
    private readonly EventService _eventService;
    private readonly IMapper _mapper;

    public EventController(EventService eventService)
    {
        _eventService = eventService;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        try
        {
            ActionResult result = StatusCode(500);
            List<EventResponse> events = _mapper.Map<List<Event>, List<EventResponse>>(await _eventService.GetAllAsync());
            if (!events.IsNullOrEmpty())
            {
                result = Ok(events);
            }

            return result;
        }
        catch (Exception e)
        {
            return StatusCode(500, e.StackTrace);
        }
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult> GetById(int id)
    {
        try
        {
            ActionResult result = StatusCode(500);
            EventResponse? returnedEvent = _mapper.Map<EventResponse>(await _eventService.GetById(id));
            if (returnedEvent != null) {
                result = Ok(returnedEvent);
            }
            return result;
        }
        catch (Exception e)
        {
            return StatusCode(500, e.StackTrace);
        }
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] CreateEventRequestDto newEvent)
    {
        Event eventToInsert = _mapper.Map<Event>(newEvent);
        try
        {
            EventResponse eventResponse =
                _mapper.Map<EventResponse>((await _eventService.CreateAsync(eventToInsert)).Entity);

            _eventService.SaveChangesAsync();

            return Ok(eventResponse);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.StackTrace);
        }
    }

    [HttpPut]
    [Route("{id:int}")]
    public async Task<ActionResult> Update(int id, [FromBody] UpdateEventRequestDto updatedEvent)
    {
        Event eventDataToUpdate = _mapper.Map<Event>(updatedEvent);
        try
        {
            EventResponse eventResponse =
                _mapper.Map<EventResponse>((await _eventService.UpdateAsync(id, eventDataToUpdate)));

            _eventService.SaveChangesAsync();

            return Ok(eventResponse);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.StackTrace);
        }
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult> Delete(int id)
    {
        try
        {
            return Ok(await _eventService.DeleteAsync(id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.StackTrace);
        }
    }
}