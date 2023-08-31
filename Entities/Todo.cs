using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JituAuth.Entities
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; }=string.Empty;
        public DateTime CreatedDate { get; set;}=DateTime.Now;
        public DateTime EndtedDate { get; set;}=DateTime.Now.AddDays(1);

    }
}
