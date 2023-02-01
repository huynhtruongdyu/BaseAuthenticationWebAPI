using System.ComponentModel;

namespace BaseAuthenticationWebAPI.Core.Domain.Enums
{
    public enum EnumTodoStatus
    {
        [Description("New")]
        New,

        [Description("Todo")]
        ToDo,

        [Description("Next")]
        Next,

        [Description("Active")]
        Active,

        [Description("Review")]
        Review,

        [Description("On hold")]
        OnHold,

        [Description("Abandoned")]
        Abandoned,

        [Description("Completed")]
        Completed,
    }
}