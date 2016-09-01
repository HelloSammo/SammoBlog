using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sammo.Blog.Web.Areas.Admin.ViewModels.Blog
{
    public class AddBlogViewModel
    {
        [Required, MaxLength(BlogConstants.Validation.BlogTitleLength)]
        public string Title { get; set; }

        [Required]
        public string Article { get; set; }

        [Display(Name ="是否置顶？")]
        public bool IsTop { get; set; }

        //[Required]
        public string CategoryId { get; set; }

        //[Required]
        public string AuthorId { get; set; }

        public string TagNameString { get; set; }
    }
}