using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Common
{
    public class JsonData<T> 
    {
        public JsonData()
        {

        }

        public JsonData(bool succeeded, string message, T data)
        {
            Succeeded = succeeded;
            Message = message;
            Data = data;
        }

        public  bool Succeeded { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
        
    }
}
