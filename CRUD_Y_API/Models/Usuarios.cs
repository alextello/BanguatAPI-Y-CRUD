using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Y_API.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        string _nombre;
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Nombres {
            get { return _nombre; }
            set { _nombre = value == null ? "" : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
        }

        string _apellidos;
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value == null ? "" : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
        }

        string _curso;
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Curso
        {
            get { return _curso; }
            set { _curso = value == null ? "" : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
        }
    }
}
