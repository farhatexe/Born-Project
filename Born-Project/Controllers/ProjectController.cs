using Born_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Controllers
{
    public class ProjectController : Controller
    {
        private readonly Born_ProjectDbContext _db;
        public ProjectController(Born_ProjectDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
