
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
            this.pnlVisor = new System.Windows.Forms.Panel();
            this.tbcGestionComputadoras = new System.Windows.Forms.TabControl();
            this.tbpRegistrarEmpresa = new System.Windows.Forms.TabPage();
            this.tbpRegistrarPortatil = new System.Windows.Forms.TabPage();
            this.tbpConsultarPortatiles = new System.Windows.Forms.TabPage();
            this.pnlVisor.SuspendLayout();
            this.tbcGestionComputadoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlVisor
            // 
            this.pnlVisor.Controls.Add(this.tbcGestionComputadoras);
            this.pnlVisor.Location = new System.Drawing.Point(12, 12);
            this.pnlVisor.Name = "pnlVisor";
            this.pnlVisor.Size = new System.Drawing.Size(776, 426);
            this.pnlVisor.TabIndex = 0;
            // 
            // tbcGestionComputadoras
            // 
            this.tbcGestionComputadoras.Controls.Add(this.tbpRegistrarEmpresa);
            this.tbcGestionComputadoras.Controls.Add(this.tbpRegistrarPortatil);
            this.tbcGestionComputadoras.Controls.Add(this.tbpConsultarPortatiles);
            this.tbcGestionComputadoras.Location = new System.Drawing.Point(3, 3);
            this.tbcGestionComputadoras.Name = "tbcGestionComputadoras";
            this.tbcGestionComputadoras.SelectedIndex = 0;
            this.tbcGestionComputadoras.Size = new System.Drawing.Size(770, 420);
            this.tbcGestionComputadoras.TabIndex = 0;
            // 
            // tbpRegistrarEmpresa
            // 
            this.tbpRegistrarEmpresa.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarEmpresa.Name = "tbpRegistrarEmpresa";
            this.tbpRegistrarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarEmpresa.Size = new System.Drawing.Size(762, 394);
            this.tbpRegistrarEmpresa.TabIndex = 0;
            this.tbpRegistrarEmpresa.Text = "Registrar Empresa";
            this.tbpRegistrarEmpresa.UseVisualStyleBackColor = true;
            // 
            // tbpRegistrarPortatil
            // 
            this.tbpRegistrarPortatil.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrarPortatil.Name = "tbpRegistrarPortatil";
            this.tbpRegistrarPortatil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrarPortatil.Size = new System.Drawing.Size(762, 394);
            this.tbpRegistrarPortatil.TabIndex = 1;
            this.tbpRegistrarPortatil.Text = "Registrar Portatil";
            this.tbpRegistrarPortatil.UseVisualStyleBackColor = true;
            // 
            // tbpConsultarPortatiles
            // 
            this.tbpConsultarPortatiles.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultarPortatiles.Name = "tbpConsultarPortatiles";
            this.tbpConsultarPortatiles.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultarPortatiles.Size = new System.Drawing.Size(762, 394);
            this.tbpConsultarPortatiles.TabIndex = 2;
            this.tbpConsultarPortatiles.Text = "Consultar Portatiles";
            this.tbpConsultarPortatiles.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlVisor);
            this.Name = "frmMain";
            this.Text = "Ventana Principal";
            this.pnlVisor.ResumeLayout(false);
            this.tbcGestionComputadoras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVisor;
        private System.Windows.Forms.TabControl tbcGestionComputadoras;
        private System.Windows.Forms.TabPage tbpRegistrarEmpresa;
        private System.Windows.Forms.TabPage tbpRegistrarPortatil;
        private System.Windows.Forms.TabPage tbpConsultarPortatiles;
    }
}

