using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.Datos
{
    [Table("Areas")]
    public class Area : Base
    {
        public int AreaId { set; get; }
        public string Nombre { get; set; }
        public string Descripcion { set; get; }
        public virtual ICollection<Cargo> Cargos { set; get; }
    }
}
