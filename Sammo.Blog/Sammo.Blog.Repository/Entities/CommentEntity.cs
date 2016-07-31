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
            CreationTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }

        public DateTime CreationTime { get; set; }

        [Required, StringLength(BlogConstants.Validation.CommentLength)]
        public string Content { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string BlogId { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string UserId { get; set; }

        public BlogEntity Blog { get; set; }

        public UserEntity User { get; set; }
    }
}
