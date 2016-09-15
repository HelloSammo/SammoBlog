using Sammo.Blog.Common;
using Sammo.Blog.Core.Interfaces;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using Sammo.Blog.Web.Areas.Admin.ViewModels.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class BlogController : AdminBaseController
    {
        private readonly IBlogService _blogService;
        private readonly IUserRepository _userRepository;
        private readonly ITagService _tagService;
        public BlogController(IBlogService blogService, ITagService tagService, IUserRepository userRepository) :
            base(userRepository)
        {
            _blogService = blogService;
            _userRepository = userRepository;
            _tagService = tagService;
        }
        // GET: Admin/Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public async Task<JsonResult> Add(AddBlogViewModel model)
        {
            
            model.AuthorId = CurrentUser.Id;
            model.CategoryId = "0be6b495-06e7-4f4f-b58b-54c549e5a2f6";
            if (ModelState.IsValid)
            {
                var user = await _userRepository.GetUserByIdAsync(model.AuthorId);
                var tagNames = model.TagNameString.Split(',');
                await _tagService.AddAsync(model.TagNameString, user);
                var tags = await _tagService.QueryAsync(t => t.Author.Id == CurrentUser.Id && tagNames.Contains(t.Name));
                BlogEntity blog = new BlogEntity()
                {
                    Title = model.Title,
                    Article = model.Article,
                    CategoryId = model.CategoryId,
                    //AuthorId = model.AuthorId,
                    Author = CurrentUser,//tags.Select(t => t.Author).First(),
                    Tags = tags.ToList(),
                    IsTop = model.IsTop
                };

                if (await _blogService.AddAsync(blog))
                    return Json(new JsonData() { State = true, Message = "添加成功" });

                return Json(new JsonData { State = false, Message = "添加失败" });
            }

            return Json(model);
        }
    }
}