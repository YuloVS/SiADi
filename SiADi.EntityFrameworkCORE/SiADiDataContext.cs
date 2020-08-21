using Microsoft.EntityFrameworkCore;
using SiADi.DominioCORE.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.EntityCORE
{
    class SiADiDataContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Tipo_usuario> Tipos_usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SiADiDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
