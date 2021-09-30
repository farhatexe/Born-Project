using Born_Project.Data;
using Born_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Controllers
{
    public class UserController : BaseController
    {
        public UserController(Born_ProjectDbContext db) : base(db)
        {

        }
        public async Task<IActionResult> Index(int? pageIndex)
        {
            var userController = await UserListing<User>.CreateAsync(_db.User, pageIndex ?? 1, 10);
            return View(userController);
        }
    }
}
