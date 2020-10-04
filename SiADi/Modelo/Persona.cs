using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.Modelo
{
    [Table("Personas")]
    public class Persona : Base
    {
        public int Dni { set; get; }
        public long Cuil { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime Fecha_nacimiento { set; get; }
        public int Edad { set; get; }
        public string Direccion { set; get; }
        public long Telefono { set; get; }
        public string Codigo_qr { set; get; }
        public string Foto { set; get; }
        public Cargo Cargo { set; get; }
        public virtual ICollection<Asistencia> Asistencias { set; get; }
        public string Contraseña { get; set; }
    }
}