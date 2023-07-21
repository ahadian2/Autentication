using Autentication.Models;
using Autentication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Autentication.Controllers
{
    public class ProfileController : Controller
    {
        private MyDbContext db=new MyDbContext();

        public ActionResult Login(string ReturnUrl="/")
        {
            FormsAuthentication.SignOut();
            LoginViewModel loginViewModel = new LoginViewModel();
            loginViewModel.ReturnUrl = ReturnUrl;
            return View(loginViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "Email,Password,RememberMe,ReturnUrl")]LoginViewModel user)
        {
            if(ModelState.IsValid)
            {
                var login= db.Users.Single(t => t.Email == user.Email && t.Password == user.Password);
                if(login == null)
                {
                    ModelState.AddModelError("LoginError", "نام کاربری و یا رمز عبور اشتباه میباشد.");
                    return View();
                }
                FormsAuthentication.SetAuthCookie(user.Email, user.RememberMe);
                return Redirect(user.ReturnUrl);

            }
            ModelState.AddModelError("LoginError", "نام کاربری و یا رمز عبور اشتباه میباشد.");
            return View();

        }


        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }
    }
}