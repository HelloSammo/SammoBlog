using Sammo.Blog.Common;
using Sammo.Blog.Core.Interfaces;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Repositories.Interfaces;
using Sammo.Blog.Web.Areas.Admin.ViewModels.Mark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    //[RoutePrefix("Mark")]
    //[Route("{action=GetAllCategories}")]
    public class MarkController : AdminBaseController
    {
        private readonly ICategoryService _service;
        //private readonly IUserRepository _repository;
        public MarkController(ICategoryService service,IUserRepository repository):base(repository)
        {
            _service = service;
        }
        // GET: Admin/Mark
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Add(string name)
        {
            Requires.NotNullOrEmpty(name, nameof(name));
            var category = new CategoryEntity() { Name = name };
            var result = await _service.AddCategoryAsync(category);
            JsonData json = new JsonData();
            switch (result)
            {
                case Repository.Enums.CategoryInvokeResult.Success:
                    json.State = true;
                    json.Message = "添加成功";
                    break;
                case Repository.Enums.CategoryInvokeResult.Exists:
                    json.State = false;
                    json.Message = BlogConstants.Error.CategoryExists;
                    break;
                case Repository.Enums.CategoryInvokeResult.InvalidName:
                    json.State = false;
                    json.Message = BlogConstants.Error.InvalidCategory;
                    break;
                case Repository.Enums.CategoryInvokeResult.Failed:
                    json.State = false;
                    json.Message = "添加失败";
                    break;
            }
            return Json(json);
        }

        //[Route("Categories")]
        public async Task<JsonResult> GetAllCategories()
        {
            var categories = await _service.GetCategoriesAsync();

            JsonData json = new JsonData()
            {
                Data = categories.Select(c =>
                {
                    return new CategoryViewModel()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Description = c.Description
                    };
                }),
                State = true
            };
            return Json(json);
        }
    }
}