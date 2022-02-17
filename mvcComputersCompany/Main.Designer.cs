
namespace mvcComputersCompany
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.tbcGestionComputadoras = new System.Windows.Forms.TabControl();
            this.tbpRegistrarEmpresa = new System.Windows.Forms.TabPage();
            this.tbpRegistrarPortatil = new System.Windows.Forms.TabPage();
            this.tbpConsultarPortatiles = new System.Windows.Forms.TabPage();
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.tbcGestionComputadoras.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pnlForms);
            this.pnlContenedor.Controls.Add(this.pnlBarraMenu);
            this.pnlContenedor.Controls.Add(this.pnlBarraTitulo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 494);
            this.pnlContenedor.TabIndex = 0;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.pnlForms.Controls.Add(this.tbcGestionComputadoras);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(150, 41);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(650, 453);
            this.pnlForms.TabIndex = 3;
            // 
            // tbcGestionComputadoras
            // 
            this.tbcGestionComputadoras.Controls.Add(this.tbpRegistrarEmpresa);
            this.tbcGestionComputadoras.Controls.Add(this.tbpRegistrarPortatil);
            this.tbcGestionComputadoras.Controls.Add(this.tbpConsultarPortatiles);
            this.tbcGestionComputadoras.Location = new System.Drawing.Point(190, 173);
            this.tbcGestionComputadoras.Name = "tbcGestionComputadoras";
            this.tbcGestionComputadoras.SelectedIndex = 0;
            this.tbcGestionComputadoras.Size = new System.Drawing.Size(293, 57);
            this.tbcGestionComputadoras.TabIndex = 0;
            // 
            // tbpRegistrarEmpresa
            // 
            this.tbpRegistrarEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarEmpresa.Name = "tbpRegistrarEmpresa";
            this.tbpRegistrarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarEmpresa.Size = new System.Drawing.Size(285, 31);
            this.tbpRegistrarEmpresa.TabIndex = 0;
            this.tbpRegistrarEmpresa.Text = "Registrar Empresa";
            this.tbpRegistrarEmpresa.UseVisualStyleBackColor = true;
            // 
            // tbpRegistrarPortatil
            // 
            this.tbpRegistrarPortatil.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarPortatil.Name = "tbpRegistrarPortatil";
            this.tbpRegistrarPortatil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarPortatil.Size = new System.Drawing.Size(285, 31);
            this.tbpRegistrarPortatil.TabIndex = 1;
            this.tbpRegistrarPortatil.Text = "Registrar Portatil";
            this.tbpRegistrarPortatil.UseVisualStyleBackColor = true;
            // 
            // tbpConsultarPortatiles
            // 
            this.tbpConsultarPortatiles.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultarPortatiles.Name = "tbpConsultarPortatiles";
            this.tbpConsultarPortatiles.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultarPortatiles.Size = new System.Drawing.Size(285, 31);
            this.tbpConsultarPortatiles.TabIndex = 2;
            this.tbpConsultarPortatiles.Text = "Consultar Portatiles";
            this.tbpConsultarPortatiles.UseVisualStyleBackColor = true;
            // 
            // pnlBarraMenu
            // 
            this.pnlBarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.pnlBarraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraMenu.Location = new System.Drawing.Point(0, 41);
            this.pnlBarraMenu.Name = "pnlBarraMenu";
            this.pnlBarraMenu.Size = new System.Drawing.Size(150, 453);
            this.pnlBarraMenu.TabIndex = 2;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnSalir);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(800, 41);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(742, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseEnter += new System.EventHandler(this.btnMinimizar_MouseEnter);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(768, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas Computadoras";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.tbcGestionComputadoras.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.TabControl tbcGestionComputadoras;
        private System.Windows.Forms.TabPage tbpRegistrarEmpresa;
        private System.Windows.Forms.TabPage tbpRegistrarPortatil;
        private System.Windows.Forms.TabPage tbpConsultarPortatiles;
        private System.Windows.Forms.Panel pnlBarraMenu;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnMinimizar;
    }
}

