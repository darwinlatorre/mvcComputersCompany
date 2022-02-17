
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
            this.backGroundImage = new System.Windows.Forms.PictureBox();
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultarPortatiles = new System.Windows.Forms.Button();
            this.btnRegistrarPortatil = new System.Windows.Forms.Button();
            this.btnRegistrarEmpresa = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.pnlForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundImage)).BeginInit();
            this.pnlBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlContenedor.Size = new System.Drawing.Size(800, 600);
            this.pnlContenedor.TabIndex = 0;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.pnlForms.Controls.Add(this.backGroundImage);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(150, 40);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(650, 560);
            this.pnlForms.TabIndex = 3;
            // 
            // backGroundImage
            // 
            this.backGroundImage.Image = ((System.Drawing.Image)(resources.GetObject("backGroundImage.Image")));
            this.backGroundImage.Location = new System.Drawing.Point(215, 170);
            this.backGroundImage.Name = "backGroundImage";
            this.backGroundImage.Size = new System.Drawing.Size(220, 220);
            this.backGroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backGroundImage.TabIndex = 4;
            this.backGroundImage.TabStop = false;
            // 
            // pnlBarraMenu
            // 
            this.pnlBarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.pnlBarraMenu.Controls.Add(this.pictureBox1);
            this.pnlBarraMenu.Controls.Add(this.btnConsultarPortatiles);
            this.pnlBarraMenu.Controls.Add(this.btnRegistrarPortatil);
            this.pnlBarraMenu.Controls.Add(this.btnRegistrarEmpresa);
            this.pnlBarraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlBarraMenu.Name = "pnlBarraMenu";
            this.pnlBarraMenu.Size = new System.Drawing.Size(150, 560);
            this.pnlBarraMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultarPortatiles
            // 
            this.btnConsultarPortatiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnConsultarPortatiles.FlatAppearance.BorderSize = 0;
            this.btnConsultarPortatiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPortatiles.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPortatiles.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPortatiles.Location = new System.Drawing.Point(0, 360);
            this.btnConsultarPortatiles.Name = "btnConsultarPortatiles";
            this.btnConsultarPortatiles.Size = new System.Drawing.Size(150, 45);
            this.btnConsultarPortatiles.TabIndex = 2;
            this.btnConsultarPortatiles.Text = "Consultar Portatiles";
            this.btnConsultarPortatiles.UseVisualStyleBackColor = false;
            this.btnConsultarPortatiles.Click += new System.EventHandler(this.btnConsultarPortatiles_Click);
            // 
            // btnRegistrarPortatil
            // 
            this.btnRegistrarPortatil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnRegistrarPortatil.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPortatil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPortatil.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPortatil.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPortatil.Location = new System.Drawing.Point(0, 280);
            this.btnRegistrarPortatil.Name = "btnRegistrarPortatil";
            this.btnRegistrarPortatil.Size = new System.Drawing.Size(150, 45);
            this.btnRegistrarPortatil.TabIndex = 1;
            this.btnRegistrarPortatil.Text = "Registrar Portatil";
            this.btnRegistrarPortatil.UseVisualStyleBackColor = false;
            this.btnRegistrarPortatil.Click += new System.EventHandler(this.btnRegistrarPortatil_Click);
            // 
            // btnRegistrarEmpresa
            // 
            this.btnRegistrarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnRegistrarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmpresa.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEmpresa.Location = new System.Drawing.Point(0, 200);
            this.btnRegistrarEmpresa.Name = "btnRegistrarEmpresa";
            this.btnRegistrarEmpresa.Size = new System.Drawing.Size(150, 45);
            this.btnRegistrarEmpresa.TabIndex = 0;
            this.btnRegistrarEmpresa.Text = "Registrar Empresa";
            this.btnRegistrarEmpresa.UseVisualStyleBackColor = false;
            this.btnRegistrarEmpresa.Click += new System.EventHandler(this.btnRegistrarEmpresa_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.pnlBarraTitulo.Controls.Add(this.lblStatus);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnSalir);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(800, 40);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(740, 12);
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "No conectado";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backGroundImage)).EndInit();
            this.pnlBarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlBarraMenu;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Button btnConsultarPortatiles;
        private System.Windows.Forms.Button btnRegistrarPortatil;
        private System.Windows.Forms.Button btnRegistrarEmpresa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox backGroundImage;
        private System.Windows.Forms.Label lblStatus;
    }
}

