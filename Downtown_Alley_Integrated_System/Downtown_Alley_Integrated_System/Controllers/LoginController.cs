using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Downtown_Alley_Integrated_System.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {

            using (SBIT3J_SystemEntities db =new SBIT3J_SystemEntities())
            {

                var result = db.Users.Where(x => x.UserId == x.UserId && x.Password == user.Password);
                if (result.Count() != 0)
                {
                    RedirectToAction("Index", "Cashier");
                }
                else
                {
                    TempData["msg"] = "Incorrect UserId/Password";
                }
            }
                return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}