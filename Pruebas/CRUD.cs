using SiADi.DominioCORE.Modelos;
using SiADi.DominioCORE.Servicios;
using SiADi.EntityCORE;
using SiADi.EntityCORE.Servicios;
using System;
using System.Linq;

namespace Pruebas
{
    class CRUD
    {
        static void Main(string[] args)
        {
            IDataService<Tipo_usuario> servicio_tipo_usuario = new GenericDataService<Tipo_usuario>(new SiADiDbContextFactory());
            servicio_tipo_usuario.Crear(new Tipo_usuario { Descripcion = "Prueba" }).Wait();
            Console.WriteLine(servicio_tipo_usuario.GetAll().Result.Count());

            //IDataService<Cargo> servicio_cargo = new GenericDataService<Cargo>(new SiADiDbContextFactory());
            //servicio_cargo.Crear(new Cargo { Descripcion = "Prueba Cargo", Horario_entrada = new DateTime(2020, 08, 22, 8, 0, 0), Horario_salida = new DateTime(2020, 08, 22, 13, 0, 0), Nivel = 1, Salario = 350 }); 

            //IDataService<Area> servicio_area = new GenericDataService<Area>(new SiADiDbContextFactory());
            //servicio_area.Crear(new Area { Descripcion = "Prueba area" }); 
        }
    }
}
