using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mvcDatabaseInfo.logica;

namespace mvcDatabaseInfo
{
    public partial class frmListaRestricciones : Form
    {
        DiccionarioDatos atrDiccionarioDatos = new DiccionarioDatos();
        public frmListaRestricciones()
        {
            InitializeComponent();
            dgvRestricciones.DataSource = atrDiccionarioDatos.obtenerRestricciones();
            dgvRestricciones.DataMember = "Restricciones";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
