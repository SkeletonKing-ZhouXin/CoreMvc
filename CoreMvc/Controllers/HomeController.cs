using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Models;

namespace CoreMvc.Controllers
{
    public class HomeController : Controller
    {

        RM_DBContext db = new RM_DBContext();

        public IActionResult Index()
        {
            var first = db.BaseUserInfo.Where(q=>q.UserAccount=="sa").FirstOrDefault();
            ViewBag.Title = first.UserName;
            return View();
        }
    }
}