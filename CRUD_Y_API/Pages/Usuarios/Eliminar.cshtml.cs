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
    public class EliminarModel : PageModel
    {
        private readonly DBContext _context;
        [TempData]
        public string Mensaje { get; set; }
        public EliminarModel(DBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var Usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(Usuario);
            await _context.SaveChangesAsync();
            Mensaje = "El usuario ha sido eliminado correctamente";
            return new RedirectToPageResult("/Usuarios/Index");
        }
    }
}