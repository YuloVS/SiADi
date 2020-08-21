using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Area : DomainObject
    {
        public string Descripcion { set; get; }
        public IEnumerable<Cargo> Cargos { set; get; }
    }
}
