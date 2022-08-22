using Matricula.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.BD.Data
{
    public class BD1 : DbContext
    {

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public BD1(DbContextOptions options) : base(options)
        {
        }
    }
}
