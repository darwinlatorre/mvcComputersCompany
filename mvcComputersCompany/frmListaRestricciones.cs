using System;
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
            dgvRestricciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
