using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStoreApp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Name {  get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin or Customer
        public ICollection<Order> Orders { get; set; }
    }
}
