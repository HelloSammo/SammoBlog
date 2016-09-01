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
    [Table("Comment")]
    public class CommentEntity
    {
        public CommentEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }

        public DateTime CreateTime { get; set; }

        [Required, StringLength(BlogConstants.Validation.CommentLength)]
        public string Content { get; set; }

        [Required]
        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string BlogId { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string AuthorId { get; set; }

        public virtual BlogEntity Blog { get; set; }

        public virtual UserEntity Author { get; set; }
    }
}
