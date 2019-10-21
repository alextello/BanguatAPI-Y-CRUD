using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Y_API.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
