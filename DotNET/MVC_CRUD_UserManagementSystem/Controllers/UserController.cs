using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_UserManagementSystem.Services;
using MVC_CRUD_UserManagementSystem.Models;

namespace MVC_CRUD_UserManagementSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = UserServices.GetAll();
            return View(users);
        }
        public IActionResult Add() { return View(); }
        public IActionResult Edit() { return View(); }
        public IActionResult Delete() { return View(); }
        
        [HttpPost]
        public IActionResult Add(UserModel model)
        {
            UserServices.Add(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(UserModel model)
        {
            UserServices.Update(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            UserServices.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
