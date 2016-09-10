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
    [Table("Tag")]
    public class TagEntity: EntityBase
    {
        public TagEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }

        [Required, StringLength(BlogConstants.Validation.TagNameLength)]
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(BlogConstants.Validation.TagDescriptionLength)]
        public string Description { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string AuthorId { get; set; }

        public virtual UserEntity Author { get; set; }

        public virtual ICollection<BlogEntity> Blogs { get; set; }
    }
}
