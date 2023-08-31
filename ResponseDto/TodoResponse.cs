using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JituAuth.ResponseDto
{
    public class TodoResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
    }
}
