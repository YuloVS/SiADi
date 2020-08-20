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
    }
}
