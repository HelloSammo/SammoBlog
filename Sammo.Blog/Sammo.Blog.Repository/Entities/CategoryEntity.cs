using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammo.Blog.Repository.Entities
{
    [Table("Category")]
    public class CategoryEntity
    {
        public CategoryEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreationTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }

        [Required, StringLength(BlogConstants.Validation.CategoryNameLength)]
        public string Name { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
