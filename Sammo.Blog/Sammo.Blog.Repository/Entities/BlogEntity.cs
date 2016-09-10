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
    public class BlogEntity: EntityBase
    {
        public BlogEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            IsTop = false;
            PageViews = 1;
        }
        [Key]
        public string Id { get; set; }

        [Required, MaxLength(BlogConstants.Validation.BlogTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Article { get; set; }

        [Required]
        public DateTime CreateTime { get; set; }

        public int PageViews { get; set; }

        public bool IsTop { get; set; }

        [Required]
        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string AuthorId { get; set; }

        [Required]
        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string CategoryId { get; set; }

        public virtual UserEntity Author { get; set; }

        public virtual CategoryEntity Category { get; set; }

        public virtual ICollection<TagEntity> Tags { get; set; }

        public virtual ICollection<CommentEntity> Comments { get; set; }
    }
}
