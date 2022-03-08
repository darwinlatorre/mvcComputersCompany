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
using mvcComputersCompany.logica;

namespace mvcComputersCompany
{
    public partial class frmAlmacenamiento : Form
    {
        DiccionarioDatos atrDiccionarioDatos = new DiccionarioDatos();
        public frmAlmacenamiento()
        {
            InitializeComponent();
            DataSet varDataSet = new DataSet();
            varDataSet = atrDiccionarioDatos.obtenerAlmacenamiento();
            chtAlmacenamiento.Series[0].Points.DataBindXY(varDataSet.Tables[0].Rows[0][0].ToString(), varDataSet.Tables[0].Rows[0][1].ToString());
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
