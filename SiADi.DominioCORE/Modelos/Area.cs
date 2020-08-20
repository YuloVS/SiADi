using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Area
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public IEnumerable<Cargo> Cargos { set; get; }
    }
}
