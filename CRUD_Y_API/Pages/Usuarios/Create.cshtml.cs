using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Y_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_Y_API.Pages.Usuarios
{
    [Authorize]
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Models.Usuarios Usuario { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        private readonly DBContext _context;
        public CreateModel(DBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Update(Usuario);
            await _context.SaveChangesAsync();
            Mensaje = "Usuario creado correctamente";
            return new RedirectToPageResult("/Usuarios/Index");

        }
    }
}