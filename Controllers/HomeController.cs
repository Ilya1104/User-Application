using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UserApp.Models;

namespace UserApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       

        private readonly UserAppRepository _usersRepository;
        private readonly UserContext context;
        public HomeController(UserAppRepository usersRepository, UserContext context)
        {
            this._usersRepository = usersRepository;
            this.context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
              var users = _usersRepository.GetUsers();
              ViewBag.Users = users;
              return View();
        }

       
       [HttpGet]
        public IActionResult UsersEdit(Guid id)
        {
            //либо создаем новую статью, либо выбираем существующую и передаем в качестве модели в представление
            User users = id == default ? new User() : _usersRepository.GetUserById(id);
            ViewBag.Users = users;
            return View(users);
        }
        [HttpPost] //в POST-версии метода сохраняем/обновляем запись в БД
        public IActionResult UsersEdit(User users)
        {
            if (ModelState.IsValid)
            {
                _usersRepository.UpdateUser(users);
                return RedirectToAction("Index");
            }
            ViewBag.Users = users;
            return View();
        }
       
        [HttpGet] //т.к. удаление статьи изменяет состояние приложения, нельзя использовать метод GET
        public IActionResult UsersDelete(Guid id)
        {
            _usersRepository.DeleteUser(new User() { Id = id });
            return RedirectToAction("Index");
        }

        [Authorize(Roles= "Field Worker")]
        public IActionResult About()
        {
            return View();
        }
        [Authorize(Roles = "Editor")]
        public IActionResult Contacts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
