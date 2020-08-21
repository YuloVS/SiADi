using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Area : Base
    {
        public string Descripcion { set; get; }
        public IEnumerable<Cargo> Cargos { set; get; }
    }
}
