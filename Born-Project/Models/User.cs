using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Models
{
    public class User
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }
        public byte[] Icon { get; set; }

    }
}
