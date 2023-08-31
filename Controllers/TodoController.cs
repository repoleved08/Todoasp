using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JituAuth.Entities;
using JituAuth.Requests;
using JituAuth.ResponseDto;
using Microsoft.AspNetCore.Mvc;

namespace JituAuth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private static List<Todo> _todos = new List<Todo>()
        {
            { new Todo()
            { 
                Id = Guid.NewGuid(),
                Title = "Learn ASP.NET",
                Description = "Using Documentation",
                EndtedDate = DateTime.Now.AddDays(1),
            }
            }
        };
        private readonly IMapper _mapper;
        public TodoController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // Getting a list of todos
        [HttpGet]
        public ActionResult <List<TodoResponse>> GetAllTodos() 
        {
            var todos = _mapper.Map<List<Todo>, List<TodoResponse>>(_todos);
            return Ok(todos);
        }

        [HttpPost]
        public ActionResult<TodoSuccess> AddTodo(AddTodo todo)
        {
            var newTodo = _mapper.Map<Todo>(todo);
            newTodo.Id = Guid.NewGuid();
            _todos.Add(newTodo);
            return Ok(new TodoSuccess(201, "Todo succesfully created!"));
        }

    }
}
