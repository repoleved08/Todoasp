using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JituAuth.Entities;
using JituAuth.Requests;
using JituAuth.ResponseDto;

namespace JituAuth.TodoProfile
{
    public class TodosProfile : Profile
    {
        public TodosProfile()
        {
            CreateMap<Todo, TodoResponse>().ReverseMap();
            CreateMap<AddTodo, Todo>().ReverseMap();
        }
    }
}
