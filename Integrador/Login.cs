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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.iNTEGRADORNETDataSet.USUARIO);
            TbxUsuario.Select(0, 0);
            TbxUsuario.Focus();
        }

        private void TsmISalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario, Contrasena;
            Usuario = TbxUsuario.Text.Trim();
            Contrasena = TbxContraseña.Text.TrimEnd();

            if (Usuario == "SA" && Contrasena == "CLASE2023" || Usuario=="ADMIN" && Contrasena=="12345678"|| Usuario=="PSUAREZ" && Contrasena=="CLASE")
            {
                Close();
                FrmPrincipal datos = new FrmPrincipal();
                datos.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                TbxUsuario.Clear();
                TbxContraseña.Clear();
                TbxUsuario.Select(0, 0);
                TbxContraseña.Focus();
            }
        }
        Validar objValidar = new Validar();
        private void TbxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarLetter(e);
            objValidar.ToUpper(e);
        }


        private void TbxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ToUpper(e);
        }

        private void PbxMostrar_Click(object sender, EventArgs e)
        {
            PbxOcult.BringToFront();
            TbxContraseña.PasswordChar = '\0'; 
        }

        private void PbxOcult_Click(object sender, EventArgs e)
        {
            PbxMostrar.BringToFront();
            TbxContraseña.PasswordChar = '*';
        }

        private void TsCerrarLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
