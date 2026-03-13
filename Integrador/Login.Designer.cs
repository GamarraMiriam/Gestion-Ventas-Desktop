namespace Integrador
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PbxMostrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbxContraseña = new System.Windows.Forms.TextBox();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.LblContra = new System.Windows.Forms.Label();
            this.LblUsu = new System.Windows.Forms.Label();
            this.PbxOcult = new System.Windows.Forms.PictureBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsMiArchivoLog = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmISalir = new System.Windows.Forms.ToolStripMenuItem();
            this.iNTEGRADORNETDataSet = new Integrador.INTEGRADORNETDataSet();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Integrador.INTEGRADORNETDataSetTableAdapters.USUARIOTableAdapter();
            this.tableAdapterManager = new Integrador.INTEGRADORNETDataSetTableAdapters.TableAdapterManager();
            this.TsCerrarLog = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOcult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNTEGRADORNETDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Controls.Add(this.PbxOcult);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TbxContraseña);
            this.groupBox1.Controls.Add(this.TbxUsuario);
            this.groupBox1.Controls.Add(this.LblContra);
            this.groupBox1.Controls.Add(this.LblUsu);
            this.groupBox1.Controls.Add(this.PbxMostrar);
            this.groupBox1.Location = new System.Drawing.Point(193, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // PbxMostrar
            // 
            this.PbxMostrar.Image = ((System.Drawing.Image)(resources.GetObject("PbxMostrar.Image")));
            this.PbxMostrar.Location = new System.Drawing.Point(396, 237);
            this.PbxMostrar.Name = "PbxMostrar";
            this.PbxMostrar.Size = new System.Drawing.Size(25, 25);
            this.PbxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMostrar.TabIndex = 5;
            this.PbxMostrar.TabStop = false;
            this.PbxMostrar.Click += new System.EventHandler(this.PbxMostrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TbxContraseña
            // 
            this.TbxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxContraseña.Location = new System.Drawing.Point(221, 237);
            this.TbxContraseña.Name = "TbxContraseña";
            this.TbxContraseña.PasswordChar = '*';
            this.TbxContraseña.Size = new System.Drawing.Size(146, 27);
            this.TbxContraseña.TabIndex = 3;
            this.TbxContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxContraseña_KeyPress);
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsuario.Location = new System.Drawing.Point(221, 153);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(146, 27);
            this.TbxUsuario.TabIndex = 2;
            this.TbxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUsuario_KeyPress);
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContra.Location = new System.Drawing.Point(34, 240);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(106, 24);
            this.LblContra.TabIndex = 1;
            this.LblContra.Text = "Contraseña";
            // 
            // LblUsu
            // 
            this.LblUsu.AutoSize = true;
            this.LblUsu.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsu.Location = new System.Drawing.Point(34, 153);
            this.LblUsu.Name = "LblUsu";
            this.LblUsu.Size = new System.Drawing.Size(75, 24);
            this.LblUsu.TabIndex = 0;
            this.LblUsu.Text = "Usuario";
            // 
            // PbxOcult
            // 
            this.PbxOcult.Image = ((System.Drawing.Image)(resources.GetObject("PbxOcult.Image")));
            this.PbxOcult.Location = new System.Drawing.Point(396, 237);
            this.PbxOcult.Name = "PbxOcult";
            this.PbxOcult.Size = new System.Drawing.Size(25, 25);
            this.PbxOcult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxOcult.TabIndex = 6;
            this.PbxOcult.TabStop = false;
            this.PbxOcult.Click += new System.EventHandler(this.PbxOcult_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.Location = new System.Drawing.Point(354, 488);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(119, 37);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(293, 52);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(235, 44);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Iniciar sesion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMiArchivoLog});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsMiArchivoLog
            // 
            this.TsMiArchivoLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmISalir,
            this.TsCerrarLog});
            this.TsMiArchivoLog.Image = ((System.Drawing.Image)(resources.GetObject("TsMiArchivoLog.Image")));
            this.TsMiArchivoLog.Name = "TsMiArchivoLog";
            this.TsMiArchivoLog.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsMiArchivoLog.Size = new System.Drawing.Size(93, 24);
            this.TsMiArchivoLog.Text = "Archivo";
            // 
            // TsmISalir
            // 
            this.TsmISalir.Name = "TsmISalir";
            this.TsmISalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsmISalir.Size = new System.Drawing.Size(224, 26);
            this.TsmISalir.Text = "Salir";
            this.TsmISalir.Click += new System.EventHandler(this.TsmISalir_Click);
            // 
            // iNTEGRADORNETDataSet
            // 
            this.iNTEGRADORNETDataSet.DataSetName = "INTEGRADORNETDataSet";
            this.iNTEGRADORNETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.iNTEGRADORNETDataSet;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTEEMPRESATableAdapter = null;
            this.tableAdapterManager.CLIENTEINDIVIDUOTableAdapter = null;
            this.tableAdapterManager.PRODUCTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Integrador.INTEGRADORNETDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = this.uSUARIOTableAdapter;
            this.tableAdapterManager.VENDEDORTableAdapter = null;
            // 
            // TsCerrarLog
            // 
            this.TsCerrarLog.Name = "TsCerrarLog";
            this.TsCerrarLog.Size = new System.Drawing.Size(224, 26);
            this.TsCerrarLog.Text = "Cerrar sesion";
            this.TsCerrarLog.Click += new System.EventHandler(this.TsCerrarLog_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxOcult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNTEGRADORNETDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxContraseña;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.Label LblUsu;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsMiArchivoLog;
        private System.Windows.Forms.ToolStripMenuItem TsmISalir;
        private INTEGRADORNETDataSet iNTEGRADORNETDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private INTEGRADORNETDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private INTEGRADORNETDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox PbxMostrar;
        private System.Windows.Forms.PictureBox PbxOcult;
        private System.Windows.Forms.ToolStripMenuItem TsCerrarLog;
    }
}