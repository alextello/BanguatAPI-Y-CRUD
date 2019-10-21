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
    public class EditModel : PageModel
    {
        [BindProperty]
        public Models.Usuarios Usuario { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        private readonly DBContext _context;
        public EditModel(DBContext context)
        {
            _context = context;
        }
        public void OnGet(int id)
        {
            Usuario = _context.Usuarios.Find(id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            _context.Usuarios.Update(Usuario);
            await _context.SaveChangesAsync();
            Mensaje = "Editado correctamente";
            return new RedirectToPageResult("/Usuarios/Index");
        }
    }
}