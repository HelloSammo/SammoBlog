using Microsoft.AspNet.Identity.EntityFramework;
using Sammo.Blog.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Sammo.Blog.Repository.Entities
{
    [Table("User")]
    public class UserEntity: EntityBase
    {
        public UserEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            Role = UserRole.User;
            IsConfirmed = false;
            IsLocked = false;
        }
        [Key]
        public  string Id { get; set; }
        [Required, StringLength(BlogConstants.Validation.UserNameLength)]
        public  string UserName { get; set; }
        [Required, StringLength(BlogConstants.Validation.EmailLength)]
        public  string Email { get; set; }

        [Required, StringLength(BlogConstants.Validation.PasswordLength)]
        public string Password { get; set; }

        [Required, StringLength(BlogConstants.Validation.PasswordLength)]
        public string PasswordSalt { get; set; }

        public UserRole Role { get; set; }


        [StringLength(BlogConstants.Validation.GuidStringLength)]
        public string AvatarId { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsLocked { get; set; }

        public DateTime CreateTime { get; set; }

        public virtual ICollection<BlogEntity> Blogs { get; set; }

        public virtual ICollection<CommentEntity> Comments { get; set; }

        public virtual ICollection<TagEntity> Tags { get; set; }
    }
}
