using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Models
{
    public class Project
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Status { get; set; } 
        public DateTime DueDate { get; set; }
        public decimal Budget { get; set; }
        public byte[] Logo { get; set; }
    }
}
