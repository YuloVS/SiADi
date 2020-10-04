using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.Datos
{
    public class Base
    { 
        [Key]
        public int Id { set; get; }
    }
}
