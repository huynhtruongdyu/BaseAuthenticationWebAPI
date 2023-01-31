using BaseAuthenticationWebAPI.Core.Domain.Enums;

namespace BaseAuthenticationWebAPI.Core.Domain.Entities
{
    public class Todo : BaseAuditEntity
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public EnumTodoStatus Status { get; set; }
    }
}