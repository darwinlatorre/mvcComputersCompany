
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
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backGroundImage = new System.Windows.Forms.PictureBox();
            this.pnlBarraMenu = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.iconImage = new System.Windows.Forms.PictureBox();
            this.btnInformacionTabla = new System.Windows.Forms.Button();
            this.btnListaRestricciones = new System.Windows.Forms.Button();
            this.btnAlmacenamiento = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundImage)).BeginInit();
            this.pnlBarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).BeginInit();
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
            this.pnlForms.Controls.Add(this.pnlStatus);
            this.pnlForms.Controls.Add(this.backGroundImage);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(150, 40);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(650, 560);
            this.pnlForms.TabIndex = 3;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 520);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(650, 40);
            this.pnlStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(6, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "No conectado";
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
            this.pnlBarraMenu.Controls.Add(this.btnConectar);
            this.pnlBarraMenu.Controls.Add(this.lblPassword);
            this.pnlBarraMenu.Controls.Add(this.lblUsuario);
            this.pnlBarraMenu.Controls.Add(this.txbPassword);
            this.pnlBarraMenu.Controls.Add(this.txbUsuario);
            this.pnlBarraMenu.Controls.Add(this.iconImage);
            this.pnlBarraMenu.Controls.Add(this.btnInformacionTabla);
            this.pnlBarraMenu.Controls.Add(this.btnListaRestricciones);
            this.pnlBarraMenu.Controls.Add(this.btnAlmacenamiento);
            this.pnlBarraMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBarraMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlBarraMenu.Name = "pnlBarraMenu";
            this.pnlBarraMenu.Size = new System.Drawing.Size(150, 560);
            this.pnlBarraMenu.TabIndex = 2;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(0, 503);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(150, 45);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(31, 440);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(43, 387);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 17);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.White;
            this.txbPassword.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(25, 460);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(100, 20);
            this.txbPassword.TabIndex = 5;
            this.txbPassword.Text = "oracle";
            // 
            // txbUsuario
            // 
            this.txbUsuario.BackColor = System.Drawing.Color.White;
            this.txbUsuario.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(25, 407);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbUsuario.TabIndex = 4;
            this.txbUsuario.Text = "prueba";
            // 
            // iconImage
            // 
            this.iconImage.Image = ((System.Drawing.Image)(resources.GetObject("iconImage.Image")));
            this.iconImage.Location = new System.Drawing.Point(25, 6);
            this.iconImage.Name = "iconImage";
            this.iconImage.Size = new System.Drawing.Size(100, 125);
            this.iconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconImage.TabIndex = 3;
            this.iconImage.TabStop = false;
            // 
            // btnInformacionTabla
            // 
            this.btnInformacionTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnInformacionTabla.Enabled = false;
            this.btnInformacionTabla.FlatAppearance.BorderSize = 0;
            this.btnInformacionTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionTabla.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacionTabla.ForeColor = System.Drawing.Color.White;
            this.btnInformacionTabla.Location = new System.Drawing.Point(0, 315);
            this.btnInformacionTabla.Name = "btnInformacionTabla";
            this.btnInformacionTabla.Size = new System.Drawing.Size(150, 45);
            this.btnInformacionTabla.TabIndex = 2;
            this.btnInformacionTabla.Text = "Informacion de tabla";
            this.btnInformacionTabla.UseVisualStyleBackColor = false;
            this.btnInformacionTabla.Click += new System.EventHandler(this.btnInformacionTabla_Click);
            // 
            // btnListaRestricciones
            // 
            this.btnListaRestricciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnListaRestricciones.Enabled = false;
            this.btnListaRestricciones.FlatAppearance.BorderSize = 0;
            this.btnListaRestricciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaRestricciones.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaRestricciones.ForeColor = System.Drawing.Color.White;
            this.btnListaRestricciones.Location = new System.Drawing.Point(0, 235);
            this.btnListaRestricciones.Name = "btnListaRestricciones";
            this.btnListaRestricciones.Size = new System.Drawing.Size(150, 45);
            this.btnListaRestricciones.TabIndex = 1;
            this.btnListaRestricciones.Text = "Lista de restricciones";
            this.btnListaRestricciones.UseVisualStyleBackColor = false;
            this.btnListaRestricciones.Click += new System.EventHandler(this.btnListaRestricciones_Click);
            // 
            // btnAlmacenamiento
            // 
            this.btnAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.btnAlmacenamiento.Enabled = false;
            this.btnAlmacenamiento.FlatAppearance.BorderSize = 0;
            this.btnAlmacenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacenamiento.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenamiento.ForeColor = System.Drawing.Color.White;
            this.btnAlmacenamiento.Location = new System.Drawing.Point(0, 155);
            this.btnAlmacenamiento.Name = "btnAlmacenamiento";
            this.btnAlmacenamiento.Size = new System.Drawing.Size(150, 45);
            this.btnAlmacenamiento.TabIndex = 0;
            this.btnAlmacenamiento.Text = "Almacenamiento";
            this.btnAlmacenamiento.UseVisualStyleBackColor = false;
            this.btnAlmacenamiento.Click += new System.EventHandler(this.btnAlmacenamiento_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.pnlBarraTitulo.Controls.Add(this.lblTitle);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnSalir);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(800, 40);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 25);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Visor Diccionario de Datos";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundImage)).EndInit();
            this.pnlBarraMenu.ResumeLayout(false);
            this.pnlBarraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconImage)).EndInit();
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
        private System.Windows.Forms.Button btnInformacionTabla;
        private System.Windows.Forms.Button btnListaRestricciones;
        private System.Windows.Forms.Button btnAlmacenamiento;
        private System.Windows.Forms.PictureBox iconImage;
        private System.Windows.Forms.PictureBox backGroundImage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblTitle;
    }
}

