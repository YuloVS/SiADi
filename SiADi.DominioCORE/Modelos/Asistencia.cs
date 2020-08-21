using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Asistencia : DomainObject
    {
        public DateTime Fecha { set; get; }
        public DateTime Hora { set; get; }
        public bool Tipo { set; get; }

    }
}
