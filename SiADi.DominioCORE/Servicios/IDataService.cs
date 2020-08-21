using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.DominioCORE.Servicios
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Crear(T entidad);
        Task<T> Actualizar(int id, T entidad);
        Task<bool> Borrar(int id);
    }
}
