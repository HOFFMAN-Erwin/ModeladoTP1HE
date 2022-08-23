using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Matricula.BD.Data.Entidades
{
    [Index(nameof(EspecialidadId),nameof(MedicoId), Name = "MatriculaEspecialidadId_UQ", IsUnique = true)]

    public class Matricula:EntityBase
    {
        [Required(ErrorMessage ="El numero de matricula es obligatorio.")]
        [MaxLength(10, ErrorMessage = "El numero de matricula no debe superar los {1} caracteres")]
        public string numMatricula { get; set; }
        [Required(ErrorMessage = "El medico es obligatorio.")]
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        [Required(ErrorMessage = "La especialidad es obligatorio.")]
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}
