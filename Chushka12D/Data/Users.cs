using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chushka12D.Data
{ 
    public class Users:IdentityUser
    {
       
        public string Name { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        

        public RoleType Role { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
