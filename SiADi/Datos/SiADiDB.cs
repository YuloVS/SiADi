namespace SiADi.Datos
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SiADiDB : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'SiADi' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'SiADi.Datos.SiADi' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'SiADi'  en el archivo de configuración de la aplicación.
        public SiADiDB() : base("Server=(localdb)\\MSSQLLocalDB;Database=SiADi;Trusted_Connection=True;")
        {
        }

        //"Server=(localdb)\\MSSQLLocalDB;Database=SiADiDB;Trusted_Connection=True;"

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Asistencia> Asistencias { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}