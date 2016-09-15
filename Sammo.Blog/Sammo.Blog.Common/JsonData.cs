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

        public JsonData(T data, string contentType = "application/json")
        {
            Data = data;
        }

        public  bool Succeeded { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
        
    }

    public class JsonData
    {
        public JsonData()
        {

        }

        public JsonData(bool success, string message=null, object data =null, string contentType = "application/json")
        {
            State = success;
            Message = message ?? string.Empty;
            Data = data ?? string.Empty;
        }

        public bool State { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }

    }
}
