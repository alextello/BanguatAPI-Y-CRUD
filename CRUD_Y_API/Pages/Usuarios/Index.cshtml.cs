using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Y_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace CRUD_Y_API.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly DBContext _context;
        public List<Models.Usuarios> Usuarios { get; set; }
        public IndexModel(DBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Usuarios = _context.Usuarios.ToList();
        }
    }
}