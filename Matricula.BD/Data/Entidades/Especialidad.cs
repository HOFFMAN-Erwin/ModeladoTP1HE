using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.BD.Data.Entidades
{
    [Index(nameof(Codigo),Name="EspecialidadCodigo_UQ",IsUnique =true)]
    public class Especialidad:EntityBase
    {
        [Required]
        [MaxLength(2, ErrorMessage = "El codigo de la especialidad no debe superar los {1} caracteres")]

        public string Codigo { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "El nombre de la especialidad no debe superar los {1} caracteres")]

        public string NomEspecialidad { get; set; }
        public List<Medico>Medicos { get; set; }
    }
}
