
namespace mvcDatabaseInfo
{
    partial class frmInformacionTabla
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblListaRestricciones = new System.Windows.Forms.Label();
            this.chtAlmacenamiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
            this.txtbTabla = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtAlmacenamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(522, 12);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 30);
            this.btnFinalizar.TabIndex = 3;
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
            this.lblListaRestricciones.Size = new System.Drawing.Size(217, 21);
            this.lblListaRestricciones.TabIndex = 6;
            this.lblListaRestricciones.Text = "Informacion de la tabla";
            // 
            // chtAlmacenamiento
            // 
            this.chtAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            chartArea1.Name = "ChartArea1";
            this.chtAlmacenamiento.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            legend1.Name = "Legend1";
            this.chtAlmacenamiento.Legends.Add(legend1);
            this.chtAlmacenamiento.Location = new System.Drawing.Point(25, 48);
            this.chtAlmacenamiento.Name = "chtAlmacenamiento";
            this.chtAlmacenamiento.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Numero de filas";
            series1.SmartLabelStyle.CalloutLineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.SmartLabelStyle.Enabled = false;
            this.chtAlmacenamiento.Series.Add(series1);
            this.chtAlmacenamiento.Size = new System.Drawing.Size(600, 400);
            this.chtAlmacenamiento.TabIndex = 7;
            this.chtAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(61, 472);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(56, 17);
            this.lblTabla.TabIndex = 8;
            this.lblTabla.Text = "Tabla:";
            // 
            // btnObtener
            // 
            this.btnObtener.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObtener.Location = new System.Drawing.Point(466, 465);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(100, 30);
            this.btnObtener.TabIndex = 9;
            this.btnObtener.Text = "Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // txtbTabla
            // 
            this.txtbTabla.Location = new System.Drawing.Point(123, 472);
            this.txtbTabla.Name = "txtbTabla";
            this.txtbTabla.Size = new System.Drawing.Size(184, 20);
            this.txtbTabla.TabIndex = 10;
            // 
            // frmInformacionTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.txtbTabla);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.chtAlmacenamiento);
            this.Controls.Add(this.lblListaRestricciones);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmInformacionTabla";
            this.Text = "frmInformacionTabla";
            ((System.ComponentModel.ISupportInitialize)(this.chtAlmacenamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblListaRestricciones;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAlmacenamiento;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.TextBox txtbTabla;
    }
}