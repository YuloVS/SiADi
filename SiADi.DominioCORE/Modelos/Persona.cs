using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Persona
    {
        public int Id { set; get; }
        public int Dni { set; get; }
        public int Cuil { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public DateTime Fecha_nacimiento { set; get; }
        public int Edad { set; get; }
        public string Direccion { set; get; }
        public int Telefono { set; get; }
        public string Codigo_qr { set; get; }
        public string Foto { set; get; }
        public Cargo Cargo { set; get; }
        public Tipo_usuario Tipo_Usuario { set; get; }
        public IEnumerable<Asistencia> Asistencias { set; get; }

    }
}
