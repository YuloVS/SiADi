using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Persona
    {
        public int id_persona { set; get; }
        public int dni { set; get; }
        public int cuil { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public DateTime fecha_nacimiento { set; get; }
        public int edad { set; get; }
        public string direccion { set; get; }
        public int id_cargo { set; get; }
        public int telefono { set; get; }
        public string codigo_qr { set; get; }
        public string foto { set; get; }
        public int id_tipo_usuario { set; get; }

    }
}
