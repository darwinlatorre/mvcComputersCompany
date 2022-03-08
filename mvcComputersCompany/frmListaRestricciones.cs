using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mvcComputersCompany.logica;

namespace mvcComputersCompany
{
    public partial class frmListaRestricciones : Form
    {
        DiccionarioDatos atrDiccionarioDatos = new DiccionarioDatos();
        public frmListaRestricciones()
        {
            InitializeComponent();
            dgvRestricciones.DataSource = atrDiccionarioDatos.obtenerRestricciones();
            dgvRestricciones.DataMember = "Restricciones";
            dgvRestricciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRestricciones.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRestricciones.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRestricciones.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvRestricciones.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
