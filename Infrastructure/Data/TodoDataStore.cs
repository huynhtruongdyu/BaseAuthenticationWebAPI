using BaseAuthenticationWebAPI.Core.Domain.Enums;
using BaseAuthenticationWebAPI.Models.Dto;

namespace BaseAuthenticationWebAPI.Infrastructure.Data
{
    public static class TodoDataStore
    {
        public static List<TodoDTO> todoList = new List<TodoDTO>
        {
            new TodoDTO(1, "Task 1", EnumTodoStatus.New),

            new TodoDTO(2, "Task 2", EnumTodoStatus.Active),

            new TodoDTO(3, "Task 3", EnumTodoStatus.Review),

            new TodoDTO(4, "Task 4", EnumTodoStatus.OnHold),

            new TodoDTO(5, "Task 5", EnumTodoStatus.Completed),
        };
    }
}