using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace UserApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserAppRepository _usersRepository;
        private readonly UserContext context;

        public AdminController(UserAppRepository usersRepository, UserContext context)
        {
            this._usersRepository = usersRepository;
            this.context = context;
        }       
        [Authorize]
        public IActionResult AdminPanel()
        {
            var users = _usersRepository.GetUsers().Include(r => r.UserRoles);
            ViewBag.Users = users;
            return View(users.ToList());
        }
        [HttpPost] //в POST-версии метода сохраняем/обновляем запись в БД
        public IActionResult UsersEdit(User users)
        {
            if (ModelState.IsValid)
            {
                _usersRepository.UpdateUser(users);
                return Redirect("/Admin/AdminPanel");
            }
            ViewBag.Users = users;
            return View();
        }
        public IActionResult UsersEdit(Guid id)
        {

            // Находим в бд футболиста
            User user = _usersRepository.GetUserById(id);
            if (user != null)
            {
                // Создаем список команд для передачи в представление
                SelectList roles = new SelectList(context.UserRoles, "Id", "Name", user.RoleId);
                ViewBag.UserRoles = roles;
                return View(user);
            }
            return RedirectToAction("/Admin/AdminPanel");
        }
        public IActionResult GetRole()
        {
            var roles = context.UserRoles.OrderBy(x => x.Name);
            ViewBag.UserRoles = roles;
            return View(roles);
        }
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRole(UserRole roles)
        {
            if (ModelState.IsValid)
            {
                _usersRepository.SaveRole(roles);
                return RedirectToAction("GetRole");
            }
            ViewBag.UserRoles = roles;
            return View(roles);
        }
        [HttpGet] //т.к. удаление статьи изменяет состояние приложения, нельзя использовать метод GET
        public IActionResult DeleteRole(Guid id)
        {
            _usersRepository.DeleteRole(new UserRole() { Id = id });
            return RedirectToAction("GetRole"); 
        }
    }
}
