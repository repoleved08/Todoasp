using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JituAuth.Requests
{
    public class AddTodo
    {
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
    }
}
