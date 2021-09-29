using Born_Project.Data;
using Born_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Controllers
{
    public class ProjectController : BaseController
    {
        public ProjectController(Born_ProjectDbContext db) : base(db)
        {

        }

        public async Task<IActionResult> Index(int? pageIndex, string filterStatus)
        {
            var projectList = await ProjectListing<Project>.CreateAsync(_db.Project
                .Where(x => (string.IsNullOrEmpty(filterStatus) || x.Status.Equals(filterStatus) || x.Status.Equals(filterStatus)))
                .Select(x => new Project 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Status = x.Status,
                    DueDate = x.DueDate,
                    Budget = x.Budget,
                    Logo = x.Logo
                }), pageIndex ?? 1, 9, filterStatus);
            

            return View(projectList);
        }
    }
}