using BaseAuthenticationWebAPI.Core.Domain.Enums;
using BaseAuthenticationWebAPI.Shared.Helper;

namespace BaseAuthenticationWebAPI.Models.Dto
{
    public class TodoDTO
    {
        public TodoDTO(long id, string name, EnumTodoStatus status)
        {
            Id = id;
            Name = name;
            Status = status;
        }

        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public EnumTodoStatus Status { get; set; } = EnumTodoStatus.New;

        public string StatusDescription { get => Status.GetDescription(); }
    }
}