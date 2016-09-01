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
    //[Table("BlogTagMap")]
    //public class BlogTagMapEntity
    //{
    //    public BlogTagMapEntity()
    //    {
    //        Id = Guid.NewGuid().ToString();
    //    }
    //    [Key]
    //    public string Id { get; set; }

    //    [StringLength(BlogConstants.Validation.GuidStringLength),Required]
    //    public string BlogId { get; set; }

    //    [StringLength(BlogConstants.Validation.GuidStringLength),Required]
    //    public string TagId { get; set; }

    //    public virtual BlogEntity Blog { get; set; }

    //    public virtual TagEntity Tag { get; set; }
    //}
}
