
namespace mvcComputersCompany
{
    partial class frmAlmacenamiento
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.chtAlmacenamiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtAlmacenamiento)).BeginInit();
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
            // chtAlmacenamiento
            // 
            this.chtAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            chartArea2.Name = "ChartArea1";
            this.chtAlmacenamiento.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            legend2.Name = "Legend1";
            this.chtAlmacenamiento.Legends.Add(legend2);
            this.chtAlmacenamiento.Location = new System.Drawing.Point(125, 80);
            this.chtAlmacenamiento.Name = "chtAlmacenamiento";
            this.chtAlmacenamiento.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtAlmacenamiento.Series.Add(series2);
            this.chtAlmacenamiento.Size = new System.Drawing.Size(400, 400);
            this.chtAlmacenamiento.TabIndex = 3;
            this.chtAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(12, 16);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(136, 21);
            this.lblAlmacenamiento.TabIndex = 4;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // frmAlmacenamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 521);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.chtAlmacenamiento);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "frmAlmacenamiento";
            this.Text = "frmAlmacenamiento";
            ((System.ComponentModel.ISupportInitialize)(this.chtAlmacenamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtAlmacenamiento;
        private System.Windows.Forms.Label lblAlmacenamiento;
    }
}