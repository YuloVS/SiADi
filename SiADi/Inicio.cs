using SiADi.Modelo;
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
            using (var db = new SiADiDB())
            {
                db.SaveChanges();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IngresoVista());
            //TestBD();
            //cambio
        }
        static void TestBD()
        {
            using (var db = new SiADiDB())
            {
                // cargos
                /*Cargo cargo1 = new Cargo { Nombre = "Data scientist", Salario = 30000, Horario_entrada = DateTime.Now, Horario_salida = DateTime.Now };
                Cargo cargo2 = new Cargo { Nombre = "Backend developer", Salario = 35000, Horario_entrada = DateTime.Now, Horario_salida = DateTime.Now };
                Cargo cargo3 = new Cargo { Nombre = "Sysadmin", Salario = 30000, Horario_entrada = DateTime.Now, Horario_salida = DateTime.Now };
                Cargo cargo4 = new Cargo { Nombre = "Frontend developer", Salario = 25000, Horario_entrada = DateTime.Now, Horario_salida = DateTime.Now };
                db.Cargos.Add(cargo1);
                db.Cargos.Add(cargo2);
                db.Cargos.Add(cargo3);
                db.Cargos.Add(cargo4);
                List<Cargo> cargos = new List<Cargo>();
                cargos.Add(cargo1);
                cargos.Add(cargo2);
                cargos.Add(cargo3);
                cargos.Add(cargo4);*/
                /* areas
                Area area = new Area { Nombre = "Sistemas", Descripcion = "Encargados de la informatización de la organización" };
                db.Areas.Add(area);
                */
                /* asistencias
                Asistencia asistencia2 = new Asistencia { Tipo = false, Fecha = DateTime.Now, Hora = DateTime.Now };
                Asistencia asistencia1 = new Asistencia { Tipo = true, Fecha = DateTime.Now, Hora = DateTime.Now };
                Asistencia asistencia3 = new Asistencia { Tipo = false, Fecha = DateTime.Now, Hora = DateTime.Now };
                Asistencia asistencia4 = new Asistencia { Tipo = true, Fecha = DateTime.Now, Hora = DateTime.Now };
                List<Asistencia> asistencias = new List<Asistencia>();
                asistencias.Add(asistencia1);
                asistencias.Add(asistencia2);
                asistencias.Add(asistencia3);
                asistencias.Add(asistencia4);
                db.Asistencias.Add(asistencia1);
                db.Asistencias.Add(asistencia2);
                db.Asistencias.Add(asistencia3);
                db.Asistencias.Add(asistencia4);
                */
                /* personas
                Persona persona = new Persona { Dni = 41471095, Cuil = 214710957, Nombre = "Giuliano", Apellido = "Vallejos Santajuliana", Codigo_qr = "asd", Contraseña = "123", Direccion = "Av. Siempre Viva 12", Edad = 22, Fecha_nacimiento = DateTime.Now, Foto = "/pepe/foto", Telefono = 37123456 };
                db.Personas.Add(persona);
                //
                db.SaveChanges();

                foreach (var cargo in db.Cargos)
                {
                    Console.WriteLine(cargo.Nombre);
                }*/
            }
        }
    }
}
