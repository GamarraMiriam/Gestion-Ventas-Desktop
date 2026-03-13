namespace Integrador
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BtnInicio = new System.Windows.Forms.Button();
            this.TsMiArchivo = new System.Windows.Forms.MenuStrip();
            this.TsMiArchivoIni = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmISalir = new System.Windows.Forms.ToolStripMenuItem();
            this.LblInicio = new System.Windows.Forms.Label();
            this.TsMiArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.Location = new System.Drawing.Point(330, 307);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(118, 37);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Text = "Ingresar";
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // TsMiArchivo
            // 
            this.TsMiArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TsMiArchivo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TsMiArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMiArchivoIni});
            this.TsMiArchivo.Location = new System.Drawing.Point(0, 0);
            this.TsMiArchivo.Name = "TsMiArchivo";
            this.TsMiArchivo.Size = new System.Drawing.Size(800, 28);
            this.TsMiArchivo.TabIndex = 1;
            this.TsMiArchivo.Text = "menuStrip1";
            // 
            // TsMiArchivoIni
            // 
            this.TsMiArchivoIni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmISalir});
            this.TsMiArchivoIni.Image = ((System.Drawing.Image)(resources.GetObject("TsMiArchivoIni.Image")));
            this.TsMiArchivoIni.Name = "TsMiArchivoIni";
            this.TsMiArchivoIni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsMiArchivoIni.Size = new System.Drawing.Size(93, 24);
            this.TsMiArchivoIni.Text = "Archivo";
            // 
            // TsmISalir
            // 
            this.TsmISalir.Name = "TsmISalir";
            this.TsmISalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsmISalir.Size = new System.Drawing.Size(174, 26);
            this.TsmISalir.Text = "Salir";
            this.TsmISalir.Click += new System.EventHandler(this.TsmISalir_Click);
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInicio.Location = new System.Drawing.Point(270, 134);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(239, 44);
            this.LblInicio.TabIndex = 2;
            this.LblInicio.Text = "Iniciar Sesion";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblInicio);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.TsMiArchivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TsMiArchivo;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.TsMiArchivo.ResumeLayout(false);
            this.TsMiArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.MenuStrip TsMiArchivo;
        private System.Windows.Forms.ToolStripMenuItem TsMiArchivoIni;
        private System.Windows.Forms.ToolStripMenuItem TsmISalir;
        private System.Windows.Forms.Label LblInicio;
    }
}