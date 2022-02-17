
namespace mvcComputersCompany
{
    partial class frmRegistrarEmpresa
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
            this.lblRegistrarEmpresa = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblDatosEmpresa = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.txbNit = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistrarEmpresa
            // 
            this.lblRegistrarEmpresa.AutoSize = true;
            this.lblRegistrarEmpresa.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarEmpresa.Location = new System.Drawing.Point(12, 16);
            this.lblRegistrarEmpresa.Name = "lblRegistrarEmpresa";
            this.lblRegistrarEmpresa.Size = new System.Drawing.Size(163, 21);
            this.lblRegistrarEmpresa.TabIndex = 0;
            this.lblRegistrarEmpresa.Text = "Registrar Empresa";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(522, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblDatosEmpresa
            // 
            this.lblDatosEmpresa.AutoSize = true;
            this.lblDatosEmpresa.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEmpresa.Location = new System.Drawing.Point(185, 110);
            this.lblDatosEmpresa.Name = "lblDatosEmpresa";
            this.lblDatosEmpresa.Size = new System.Drawing.Size(280, 21);
            this.lblDatosEmpresa.TabIndex = 2;
            this.lblDatosEmpresa.Text = "Digite los datos de la empresa";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(120, 200);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(32, 17);
            this.lblNit.TabIndex = 3;
            this.lblNit.Text = "Nit";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(120, 270);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.Location = new System.Drawing.Point(120, 340);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(144, 17);
            this.lblFechaCreacion.TabIndex = 5;
            this.lblFechaCreacion.Text = "Fecha de creacion";
            // 
            // txbNit
            // 
            this.txbNit.Location = new System.Drawing.Point(310, 200);
            this.txbNit.Name = "txbNit";
            this.txbNit.Size = new System.Drawing.Size(200, 20);
            this.txbNit.TabIndex = 6;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(310, 270);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(200, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // dtpFechaCreacion
            // 
            this.dtpFechaCreacion.Location = new System.Drawing.Point(310, 337);
            this.dtpFechaCreacion.Name = "dtpFechaCreacion";
            this.dtpFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaCreacion.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(275, 420);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaCreacion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbNit);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblDatosEmpresa);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblRegistrarEmpresa);
            this.Name = "frmRegistrarEmpresa";
            this.Text = "Registrar Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarEmpresa;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblDatosEmpresa;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.TextBox txbNit;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaCreacion;
        private System.Windows.Forms.Button btnRegistrar;
    }
}