using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Enums
{
    public enum AddTagInvokeResult
    {
        Success,
        IsNullOrEmpty,
        IsExists,
        Failed
    }
}
