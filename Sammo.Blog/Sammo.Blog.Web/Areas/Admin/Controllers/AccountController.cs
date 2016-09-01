using Sammo.Blog.Common;
using Sammo.Blog.Core.Interfaces;
using Sammo.Blog.Repository.Entities;
using Sammo.Blog.Repository.Enums;
using Sammo.Blog.Repository.Repositories.Interfaces;
using Sammo.Blog.Web.Areas.Admin.ViewModels.Account;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace Sammo.Blog.Web.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    public class AccountController : AdminBaseController
    {
        private readonly IAccountService _service;
        private readonly IUserRepository _repository;
        public AccountController(IAccountService service, IUserRepository repository) :base(repository)
        {
            this._service = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
        {
            var model = new LoginViewModel();
            string returnUrl = Request["ReturnUrl"];
            if (!string.IsNullOrEmpty(returnUrl))
                model.ReturnUrl = returnUrl;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserEntity()
                {
                    UserName = model.UserName,
                    Password = model.Password,
                    Email = model.Email
                };
                var result = await _service.RegisterAsync(user);
                switch (result)
                {
                    case UserInvokeResult.Success:
                        FormsAuthentication.SetAuthCookie(model.UserName, true);
                        return RedirectToAction("Index", "Home");

                    case UserInvokeResult.UserNameExists:
                        ModelState.AddModelError(string.Empty, BlogConstants.Error.UserNameExists);
                        break;
                    case UserInvokeResult.EmailExists:
                        ModelState.AddModelError(string.Empty, BlogConstants.Error.EmailExists);
                        break;
                    default:
                        ModelState.AddModelError(string.Empty, "注册不成功，请检查！");
                        break;
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _service.ValidateUserAsync(model.UserNameOrEmail, model.Password);
                switch (result)
                {
                    case UserLoginInvokeResult.Success:
                        FormsAuthentication.SetAuthCookie(model.UserNameOrEmail, model.RememberMe);
                        
                        if (!string.IsNullOrEmpty(model.ReturnUrl))
                            return Redirect(model.ReturnUrl);

                        return RedirectToAction("Index", "Home", new { Area = "Admin" });
                    case UserLoginInvokeResult.UserOrEmailNotFound:
                        ModelState.AddModelError(string.Empty, BlogConstants.Error.UserNotFound);
                        break;
                    case UserLoginInvokeResult.PasswordIncorrect:
                        ModelState.AddModelError(string.Empty, BlogConstants.Error.PasswordIncorrect);
                        break;
                    default:
                        break;
                }
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}