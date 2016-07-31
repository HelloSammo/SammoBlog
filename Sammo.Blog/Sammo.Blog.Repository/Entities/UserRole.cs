using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Entities
{
    public enum UserRole : byte
    {
        User = 0,
        Administrator = 1,
        System = 2
    }
}
