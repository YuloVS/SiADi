﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Cargo
    {
        public int id { set; get; }
        public string descripcion { set; get; }
        public DateTime horario_entrada { set; get; }
        public DateTime horario_salida { set; get; }
        public int id_area { set; get; }
        public int nivel { set; get; }
        public float salario { set; get; }

    }
}
