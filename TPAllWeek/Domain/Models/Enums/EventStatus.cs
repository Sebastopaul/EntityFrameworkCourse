using System.ComponentModel;

namespace TPAllWeek.Domain.Models.Enums;

public enum EventStatus
{
    [Description("Draft")]
    Draft,
    [Description("Planned")]
    Planned,
    [Description("In Progress")]
    InProgress,
    [Description("Finished")]
    Finished,
    [Description("Cancelled")]
    Cancelled,
}