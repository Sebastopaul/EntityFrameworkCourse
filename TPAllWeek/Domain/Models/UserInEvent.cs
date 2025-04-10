using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Domain.Models;

public class UserInEvent : BaseEntity
{
    public required DateTime RegistrationDate { get; set; }
    public required UserInEventStatus AttendanceStatus { get; set; }
    public int UserId { get; set; }
    public int EventId { get; set; }
    public required User User { get; set; }
    public required Event Event { get; set; }
}