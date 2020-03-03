using Project.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.MVC.Services
{
    public interface IAppUserService
    {

        AppUser GetById(int id);
        List<AppUser> GetAllUsers();

    }
}
