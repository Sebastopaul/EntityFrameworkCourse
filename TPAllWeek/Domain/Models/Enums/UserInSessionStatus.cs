using System.ComponentModel;

namespace TPAllWeek.Domain.Models.Enums;

public enum UserInSessionStatus
{
    [Description("Pending")]
    Pending,
    [Description("Refused")]
    Refused,
    [Description("Confirmed")]
    Confirmed,
}