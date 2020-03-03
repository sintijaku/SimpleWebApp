using Project.MVC.Data;
using Project.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project.MVC.Services
{
    public class AppUserService : IAppUserService
    {
        private MyContext _context;

        public AppUserService(MyContext context)
        {
            _context = context;
        }

        public List<AppUser> GetAllUsers()
        {
            return _context.AppUsers.ToList();
        }

        public AppUser GetById(int id)
        {
            return _context.AppUsers.FirstOrDefault(x => x.AppUserId == id);
        }


    }
}
