using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using mvcDatabaseInfo.logica;

namespace mvcDatabaseInfo
{
    public partial class frmAlmacenamiento : Form
    {
        DiccionarioDatos atrDiccionarioDatos = new DiccionarioDatos();
        public frmAlmacenamiento()
        {
            InitializeComponent();
            double[] vecAlmacenamiento = atrDiccionarioDatos.obtenerAlmacenamiento();
            double[] varPoint1 = new double[1];
            varPoint1[0] = double.Parse(decimal.Round((decimal)vecAlmacenamiento[0], 2).ToString());
            chtAlmacenamiento.Series[0].Points[0].YValues = varPoint1;
            double[] varPoint2 = new double[1];
            varPoint2[0] = double.Parse(decimal.Round((decimal)vecAlmacenamiento[1], 2).ToString());
            chtAlmacenamiento.Series[0].Points[1].YValues = varPoint2;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
