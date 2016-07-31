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
    [Table("Blog")]
    public class BlogEntity
    {
        public BlogEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreationTime = DateTime.Now;
            IsTop = false;
            VisitedAmount = 1;
        }
        [Key]
        public string Id { get; set; }

        [Required, MaxLength(BlogConstants.Validation.BlogTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Article { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }

        public int VisitedAmount { get; set; }

        public bool IsTop { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string UserId { get; set; }

        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string CategoryId { get; set; }

        public virtual UserEntity UserEntity { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual ICollection<TagEntity> Tags { get; set; }

        public virtual ICollection<CommentEntity> Comments { get; set; }
    }
}
