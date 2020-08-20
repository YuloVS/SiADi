using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Asistencia
    {
        public int id { set; get; }
        public DateTime fecha { set; get; }
        public DateTime hora { set; get; }
        public int id_persona { set; get; }
        public bool tipo { set; get; }

    }
}
