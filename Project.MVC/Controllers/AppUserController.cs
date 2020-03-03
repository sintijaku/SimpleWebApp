using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.MVC.Data;
using Project.MVC.Services;

namespace Project.MVC.Controllers
{
    public class AppUserController : Controller
    {
        private MyContext _context;
        private IAppUserService _service;

        public AppUserController(MyContext context, IAppUserService service)
        {
            _context = context;
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAllUsers());
        }


    }
}