using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            
        }

        private void TsmISalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
