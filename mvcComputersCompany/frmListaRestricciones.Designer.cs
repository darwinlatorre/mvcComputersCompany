
namespace mvcComputersCompany
{
    partial class frmListaRestricciones
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblListaRestricciones = new System.Windows.Forms.Label();
            this.dgvRestricciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestricciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(522, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblListaRestricciones
            // 
            this.lblListaRestricciones.AutoSize = true;
            this.lblListaRestricciones.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaRestricciones.Location = new System.Drawing.Point(12, 16);
            this.lblListaRestricciones.Name = "lblListaRestricciones";
            this.lblListaRestricciones.Size = new System.Drawing.Size(208, 21);
            this.lblListaRestricciones.TabIndex = 5;
            this.lblListaRestricciones.Text = "Lista de restricciones";
            // 
            // dgvRestricciones
            // 
            this.dgvRestricciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.dgvRestricciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestricciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.dgvRestricciones.Location = new System.Drawing.Point(25, 80);
            this.dgvRestricciones.Name = "dgvRestricciones";
            this.dgvRestricciones.Size = new System.Drawing.Size(600, 400);
            this.dgvRestricciones.TabIndex = 6;
            // 
            // frmListaRestricciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.dgvRestricciones);
            this.Controls.Add(this.lblListaRestricciones);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmListaRestricciones";
            this.Text = "frmListaRestricciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestricciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblListaRestricciones;
        private System.Windows.Forms.DataGridView dgvRestricciones;
    }
}