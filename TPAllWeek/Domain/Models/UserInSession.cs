using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Domain.Models;

public class UserInSession : BaseEntity
{
    public required DateTime RegistrationDate { get; set; }
    public required UserInSessionRole Role { get; set; }
    public required UserInSessionStatus AttendanceStatus { get; set; }
    public required int UserId { get; set; }
    public required int SessionId { get; set; }
    public required User User { get; set; }
    public required Session Session { get; set; }
}