using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Login(string name, string password)
        {
            if (name == "admin" && password == "123456")
            {
                ViewBag.Error = "登录成功";
            }
            ViewBag.Error = "登陆失败";
            return View();
        }
    }
}