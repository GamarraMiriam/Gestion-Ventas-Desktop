using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public class Validar
    {
        public void ValidarLetter (KeyPressEventArgs e) 
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo puede ingresar letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        public void ValidarNumber (KeyPressEventArgs e) 
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Solo puede ingresar numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        public void ToUpper(KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
