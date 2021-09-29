using Born_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Controllers
{
    public class BaseController : Controller
    {

        public readonly Born_ProjectDbContext _db;
        public BaseController(Born_ProjectDbContext db)
        {
            _db = db;
        }

    }
}
