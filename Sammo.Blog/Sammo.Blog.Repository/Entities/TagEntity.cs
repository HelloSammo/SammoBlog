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
    public class TagEntity
    {
        public TagEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreationTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }

        [Required, StringLength(BlogConstants.Validation.TagNameLength)]
        public string Name { get; set; }

        public DateTime CreationTime { get; set; }

        [StringLength(BlogConstants.Validation.TagDescriptionLength)]
        public string Description { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string UserId { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string BlogId { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual BlogEntity Blog { get; set; }
    }
}
