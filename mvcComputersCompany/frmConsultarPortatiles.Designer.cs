﻿
namespace mvcComputersCompany
{
    partial class frmConsultarPortatiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblDatosEmpresaPortatil = new System.Windows.Forms.Label();
            this.lblRegistrarEmpresa = new System.Windows.Forms.Label();
            this.txbNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblMarcaPortatil = new System.Windows.Forms.Label();
            this.txbMarcaPortatil = new System.Windows.Forms.TextBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultaPortatil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(522, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblDatosEmpresaPortatil
            // 
            this.lblDatosEmpresaPortatil.AutoSize = true;
            this.lblDatosEmpresaPortatil.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosEmpresaPortatil.Location = new System.Drawing.Point(125, 68);
            this.lblDatosEmpresaPortatil.Name = "lblDatosEmpresaPortatil";
            this.lblDatosEmpresaPortatil.Size = new System.Drawing.Size(379, 21);
            this.lblDatosEmpresaPortatil.TabIndex = 4;
            this.lblDatosEmpresaPortatil.Text = "Digite los datos de la empresa y portatil";
            // 
            // lblRegistrarEmpresa
            // 
            this.lblRegistrarEmpresa.AutoSize = true;
            this.lblRegistrarEmpresa.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarEmpresa.Location = new System.Drawing.Point(12, 16);
            this.lblRegistrarEmpresa.Name = "lblRegistrarEmpresa";
            this.lblRegistrarEmpresa.Size = new System.Drawing.Size(370, 21);
            this.lblRegistrarEmpresa.TabIndex = 3;
            this.lblRegistrarEmpresa.Text = "Consultar portatiles por empresa y marca";
            // 
            // txbNombreEmpresa
            // 
            this.txbNombreEmpresa.Location = new System.Drawing.Point(316, 107);
            this.txbNombreEmpresa.Name = "txbNombreEmpresa";
            this.txbNombreEmpresa.Size = new System.Drawing.Size(200, 20);
            this.txbNombreEmpresa.TabIndex = 9;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpresa.Location = new System.Drawing.Point(126, 107);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(168, 17);
            this.lblNombreEmpresa.TabIndex = 8;
            this.lblNombreEmpresa.Text = "Nombre de la empresa";
            // 
            // lblMarcaPortatil
            // 
            this.lblMarcaPortatil.AutoSize = true;
            this.lblMarcaPortatil.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaPortatil.Location = new System.Drawing.Point(126, 139);
            this.lblMarcaPortatil.Name = "lblMarcaPortatil";
            this.lblMarcaPortatil.Size = new System.Drawing.Size(152, 17);
            this.lblMarcaPortatil.TabIndex = 16;
            this.lblMarcaPortatil.Text = "Marca del portatil";
            // 
            // txbMarcaPortatil
            // 
            this.txbMarcaPortatil.Location = new System.Drawing.Point(316, 139);
            this.txbMarcaPortatil.Name = "txbMarcaPortatil";
            this.txbMarcaPortatil.Size = new System.Drawing.Size(200, 20);
            this.txbMarcaPortatil.TabIndex = 17;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToResizeColumns = false;
            this.dgvConsulta.AllowUserToResizeRows = false;
            this.dgvConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsulta.EnableHeadersVisualStyles = false;
            this.dgvConsulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.dgvConsulta.Location = new System.Drawing.Point(30, 210);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsulta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(575, 230);
            this.dgvConsulta.TabIndex = 18;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(264, 175);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 30);
            this.btnConsultar.TabIndex = 19;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultaPortatil
            // 
            this.lblConsultaPortatil.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaPortatil.Location = new System.Drawing.Point(12, 442);
            this.lblConsultaPortatil.Name = "lblConsultaPortatil";
            this.lblConsultaPortatil.Size = new System.Drawing.Size(610, 70);
            this.lblConsultaPortatil.TabIndex = 21;
            this.lblConsultaPortatil.Visible = false;
            // 
            // frmConsultarPortatiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.lblConsultaPortatil);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.txbMarcaPortatil);
            this.Controls.Add(this.lblMarcaPortatil);
            this.Controls.Add(this.txbNombreEmpresa);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.lblDatosEmpresaPortatil);
            this.Controls.Add(this.lblRegistrarEmpresa);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmConsultarPortatiles";
            this.Text = "Consultar Portatiles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblDatosEmpresaPortatil;
        private System.Windows.Forms.Label lblRegistrarEmpresa;
        private System.Windows.Forms.TextBox txbNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblMarcaPortatil;
        private System.Windows.Forms.TextBox txbMarcaPortatil;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblConsultaPortatil;
    }
}