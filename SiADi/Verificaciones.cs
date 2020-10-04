using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiADi
{
    public class Verificaciones
    {
        public void soloNumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || (Keys)e.KeyChar == Keys.Space);
        }

        public void bordeError(TextBox t, Form f)
        {
            Graphics g = f.CreateGraphics();
            System.Drawing.Rectangle rect = new Rectangle(t.Location.X, t.Location.Y, t.ClientSize.Width, t.ClientSize.Height);
            rect.Inflate(2, 2);
            System.Windows.Forms.ControlPaint.DrawBorder(g, rect, Color.Red, ButtonBorderStyle.Solid);
        }
    }
}
