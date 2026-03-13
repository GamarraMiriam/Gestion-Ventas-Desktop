using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Integrador
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOTableAdapter.Fill(this.iNTEGRADORNETDataSet.PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.CLIENTEEMPRESA' Puede moverla o quitarla según sea necesario.
            this.cLIENTEEMPRESATableAdapter.Fill(this.iNTEGRADORNETDataSet.CLIENTEEMPRESA);
            // TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.CLIENTEEMPRESA' Puede moverla o quitarla según sea necesario.
            this.cLIENTEEMPRESATableAdapter.Fill(this.iNTEGRADORNETDataSet.CLIENTEEMPRESA);
            // TODO: esta línea de código carga datos en la tabla 'iNTEGRADORNETDataSet.CLIENTEINDIVIDUO' Puede moverla o quitarla según sea necesario.
            this.cLIENTEINDIVIDUOTableAdapter.Fill(this.iNTEGRADORNETDataSet.CLIENTEINDIVIDUO);

        }

        private void TsmISalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cLIENTEINDIVIDUOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEINDIVIDUOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNTEGRADORNETDataSet);

        }
        
        private void PicBuscEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Dal objemp = new Datos.Dal();
                if (RbtnNomEmp.Checked == true)
                    if (string.IsNullOrEmpty(TxbBusEmp.Text) == true)
                    {

                    }
                    else
                    {
                        string s = TxbBusEmp.Text;
                        String result = null;
                        if (result == "")
                        {
                            MessageBox.Show("Valor invalido: " + "'" + TxbBusEmp.Text + "'", "ERROR:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DataSet ds = new DataSet();
                            ds = objemp.BuscarNombre(TxbBusEmp.Text);

                            DataTable dtEmpresa = ds.Tables[0];
                            DgvListEmp.DataSource = dtEmpresa;
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: al buscar datos" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TxbBusEmp.Text = null;
        }

        private void AgregarEmpresa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbxNombre.Text) || string.IsNullOrEmpty(TbxContac.Text))
            {
                DialogResult resultado = MessageBox.Show("Debe ingresar datos obligatorios (*)", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    TbxNombre.Select(0, 0);
                    TbxNombre.Focus();
                }
            }
            else
            {
                string VarConcatena;
                VarConcatena = "" + "\n\r" + "" +
                    "\n\r" + "Nombre: " + TbxNombre.Text +
                    "\n\r" + "Contacto: " + TbxContac.Text;

                DialogResult resultado = MessageBox.Show("¿Confirma el ingreso de los siguientes datos: " + VarConcatena, "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    string varFoto = TbxNombre.Text + ".jpg";


                    Dal objDal = new Dal();
                    objDal.AgregarEmpresa(TbxNombre.Text, TbxContac.Text, TbxCUIT.Text, TbxMail.Text, TbxTel.Text, TbxDirec.Text, varFoto);
                }
                else
                {
                    return;
                }
                Datos.Dal objdal = new Datos.Dal();
                ClienteEmpresa objAlumnos = new ClienteEmpresa();
                DataSet objds = new DataSet();

                objds = objdal.BuscarEmpresas();
                DataTable dtEmpresas = objds.Tables[0];
                DgvListEmp.DataSource = dtEmpresas;
            }
        }

        private void DgvListEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            List<string> ObjDatos = new List<string>();
            for (int i = 0; i < DgvListEmp.Rows[e.RowIndex].Cells.Count; i++)
            {
                ObjDatos.Add(DgvListEmp.Rows[e.RowIndex].Cells[i].Value.ToString());
            }
            TbxNombre.Text = ObjDatos[1];
            TbxContac.Text = ObjDatos[2];
            TbxCUIT.Text = ObjDatos[3];
            TbxMail.Text = ObjDatos[4];
            TbxTel.Text = ObjDatos[5];
            TbxDirec.Text = ObjDatos[6];

            string varFoto = ObjDatos[7];
            PbxEmp.Image = PbxEmp.InitialImage;
            string path = Path.Combine(@"C:\FOTOSEMPRESAS\", varFoto);
            if (File.Exists(path))
            {
                PbxEmp.Image = System.Drawing.Image.FromFile(path);
            }
            else
            {
                PbxEmp.Image = Image.FromFile(@"C:\FOTOSEMPRESAS\sin-fotografia.jpg");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(TbxNombre.Text) || string.IsNullOrEmpty(TbxContac.Text))
            {
                DialogResult resultado = MessageBox.Show("Debe ingresar datos obligatorios (*)", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    TbxNombre.Select(0, 0);
                    TbxNombre.Focus();
                }
            }
            else
            {
                string VarConcatena;
                VarConcatena = "" + "\n\r" + "" +
                    "\n\r" + "Nombre: " + TbxNombre.Text +
                    "\n\r" + "Contacto: " + TbxContac.Text;
                DialogResult resultado = MessageBox.Show("¿Confirma el ingreso de los siguientes datos: " + VarConcatena, "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    string varFoto = TbxNombre.Text + ".jpg";

                    Dal objDal = new Dal();
                    objDal.ModificarEmpresa( TbxNombre.Text, TbxContac.Text,
                        TbxCUIT.Text,TbxMail.Text, TbxTel.Text, TbxDirec.Text, varFoto);
                }
                else
                {
                    return;
                }
                Datos.Dal objemp = new Datos.Dal();
                ClienteEmpresa objAlumnos = new ClienteEmpresa();
                DataSet objds = new DataSet();

                objds = objemp.BuscarEmpresas();
                DataTable dtEmpresas = objds.Tables[0];
                DgvListEmp.DataSource = dtEmpresas;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Datos.Dal objdal = new Datos.Dal();
            DataSet dsl = new DataSet();
            dsl = objdal.EliminarEmpresa(TbxNombre.Text);
            MessageBox.Show("Se elimino registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Datos.Dal objdatos = new Datos.Dal();
            ClienteEmpresa objAlumnos = new ClienteEmpresa();
            DataSet objds = new DataSet();

            objds = objdal.BuscarEmpresas();

            DataTable dtEmpresas = objds.Tables[0];
            DgvListEmp.DataSource = dtEmpresas;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Datos.Dal objdal = new Datos.Dal();

            ClienteEmpresa objAlumnos = new ClienteEmpresa();

            DataSet objds = new DataSet();

            objds = objdal.BuscarNombre(TbxNombre.Text);

            DataTable dtEmpresas = objds.Tables[0];
            DgvListEmp.DataSource = dtEmpresas;
        }
        Validar objValidar = new Validar();
        private void TbxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarNumber(e);
        }

        private void TbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarLetter(e);
            objValidar.ToUpper(e);
        }

        private void TbxContac_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarLetter(e);
            objValidar.ToUpper(e);
        }

        private void TbxCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarNumber(e);
        }

        private void TbxMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //objValidar.ValidarLetter(e);
            objValidar.ToUpper(e);
        }

        private void TbxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarNumber(e);
        }

        private void TbxDirec_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarLetter(e);
            objValidar.ToUpper(e);
            //objValidar.ValidarNumber(e);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TbxNombre.Text = string.Empty;
            TbxContac.Text = string.Empty;
            TbxCUIT.Text = string.Empty;
            TbxMail.Text = string.Empty;
            TbxTel.Text = string.Empty;
            TbxDirec.Text = string.Empty;
            DgvListEmp.Text = string.Empty;

            TbxNombre.Select(0, 0);
            TbxNombre.Focus();
        }

        private void TxbBusEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            objValidar.ValidarLetter(e);
            objValidar.ToUpper(e);
        }

        private void TsmCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

