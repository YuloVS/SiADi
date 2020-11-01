using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.Modelo
{
    [Table("Cargos")]
    public class Cargo : Base
    {
        public string Nombre { set; get; }
        public double Salario { get; set; }
        public DateTime Horario_entrada { set; get; }
        public DateTime Horario_salida { set; get; }
        public int AreaId;
        public virtual Area Area { get; set; }
    }
}