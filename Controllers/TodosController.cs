using BaseAuthenticationWebAPI.Infrastructure.Data;
using BaseAuthenticationWebAPI.Models.Dto;

using Microsoft.AspNetCore.Mvc;

namespace BaseAuthenticationWebAPI.Controllers
{
    public class TodosController : ControllerBaseApi
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<TodoDTO>> GetAll()
        {
            var todos = TodoDataStore.todoList;
            return Ok(todos);
        }

        [HttpGet("{id:long}", Name = nameof(GetById))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TodoDTO> GetById(long id)
        {
            if (id == 0)
                return BadRequest();

            var todo = TodoDataStore.todoList.SingleOrDefault(x => x.Id == id);
            if (todo == null)
                return NotFound();
            return Ok(todo);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<TodoDTO> Create([FromBody] TodoDTO dto)
        {
            if (dto == null)
                return BadRequest(dto);

            if (dto.Id > 0)
                return StatusCode(StatusCodes.Status500InternalServerError);

            dto.Id = TodoDataStore.todoList.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            TodoDataStore.todoList.Add(dto);
            return Ok(dto);
        }
    }
}