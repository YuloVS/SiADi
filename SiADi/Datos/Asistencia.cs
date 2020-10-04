﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiADi.Datos
{
    [Table("Asistencias")]
    public class Asistencia : Base
    {
        public DateTime Fecha { set; get; }
        public DateTime Hora { set; get; }
        public bool Tipo { set; get; }
    }
}