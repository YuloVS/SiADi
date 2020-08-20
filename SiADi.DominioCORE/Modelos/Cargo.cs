using System;
using System.Collections.Generic;
using System.Text;

namespace SiADi.DominioCORE.Modelos
{
    public class Cargo
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public DateTime Horario_entrada { set; get; }
        public DateTime Horario_salida { set; get; }
        public int Nivel { set; get; }
        public float Salario { set; get; }
    }
}
