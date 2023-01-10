using LogIn_Form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LogIn_Form.Controllers
{
    public class UserController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogIn(UserModel model) 
        {
            ViewBag.Message = string.Format("Logged In Successfully");
            return View();
        }
    }
}
