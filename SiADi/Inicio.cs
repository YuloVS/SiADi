using SiADi.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiADi
{
    static class Inicio
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
            /*using (var db = new SiADiDB())
            {
                db.Areas.Add(new Area { Nombre = "Test area", Descripcion = "Esta es una area de prueba"});
                db.SaveChanges();

                foreach (var cargo in db.Cargos)
                {
                    Console.WriteLine(cargo.Nombre);
                }
            }*/
        }
    }
}
