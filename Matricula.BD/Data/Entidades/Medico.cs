using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.BD.Data.Entidades
{
    public class Medico: EntityBase
    {
        [Required]
        [MaxLength(8,ErrorMessage ="El DNI no debe superar los {1} caracteres.")]
        public int DNI { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "El Nombre no debe superar los {1} caracteres.")]
        public string Nombre { get; set; }
    }
}
