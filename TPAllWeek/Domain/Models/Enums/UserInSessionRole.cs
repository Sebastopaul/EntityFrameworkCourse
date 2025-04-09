using System.ComponentModel;

namespace TPAllWeek.Domain.Models.Enums;

public enum UserInSessionRole
{
    [Description("Speaker")]
    Speaker,
    [Description("Participant")]
    Participant,
}