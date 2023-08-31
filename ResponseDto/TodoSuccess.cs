using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JituAuth.ResponseDto
{
    public class TodoSuccess
    {
        public int Code { get; set; }
        public string Message { get; set; }=string.Empty;
        public TodoSuccess(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }
    }
}
