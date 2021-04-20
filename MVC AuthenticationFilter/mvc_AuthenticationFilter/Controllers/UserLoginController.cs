using mvc_AuthenticationFilter.Models;
using System;
using System.Web.Mvc;

namespace mvc_AuthenticationFilter.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {

                return View(model);
            }
            else
            {

                if (model.UserName == "Teste" && model.Password == "Teste")
                {
                    Session["UserID"] = Guid.NewGuid();
                    return RedirectToAction("Index", "Home");
                }
                else
                {

                    ModelState.AddModelError("", "Usuario invalido");
                    return View(model);
                }                
            }            
        }
    }
}