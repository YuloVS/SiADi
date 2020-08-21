using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SiADi.DominioCORE.Modelos;
using SiADi.DominioCORE.Servicios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.EntityCORE.Servicios
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly SiADiDbContextFactory _contextFactory;

        public GenericDataService(SiADiDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Actualizar(int id, T entidad)
        {
            using (SiADiDbContext context = _contextFactory.CreateDbContext())
            {
                entidad.id = id;
                context.Set<T>().Update(entidad);
                await context.SaveChangesAsync();
                return entidad;
            }
        }

        public async Task<bool> Borrar(int id)
        {
            using (SiADiDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Crear(T entidad)
        {
            using (SiADiDbContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entidad);
                await context.SaveChangesAsync();
                return createdResult.Entity;
            }
        }

        public async Task<T> Get(int id)
        {
            using (SiADiDbContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (SiADiDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }
    }
}
