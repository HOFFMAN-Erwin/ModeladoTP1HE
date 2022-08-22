using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.BD.Data.Entidades
{
    public class Matricula:EntityBase
    {
        public string numMatricula { get; set; }
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
    }
}
