using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.EntityCORE
{
    public class SiADiDbContextFactory : IDesignTimeDbContextFactory<SiADiDbContext>
    {
        public SiADiDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<SiADiDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SiADiDB;Trusted_Connection=True;");
            return new SiADiDbContext(options.Options);
        }
    }
}
