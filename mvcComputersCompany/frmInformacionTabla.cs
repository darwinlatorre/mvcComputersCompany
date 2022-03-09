using System;
using System.Data;
using System.Windows.Forms;
using mvcDatabaseInfo.logica;

namespace mvcDatabaseInfo
{
    public partial class frmInformacionTabla : Form
    {
        DiccionarioDatos atrDiccionarioDatos = new DiccionarioDatos();

        public frmInformacionTabla()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            DataSet varDataSet = atrDiccionarioDatos.obtenerNroFilasParticion(txtbTabla.Text);
            if (varDataSet.Tables[0].Rows.Count == 0)
            {
                lblStatus.Text = "No hay particiones";
            }
            else
            {
                lblStatus.Text = "";
                chtInformacion.DataSource = atrDiccionarioDatos.obtenerNroFilasParticion(txtbTabla.Text);
                chtInformacion.Series[0].XValueMember = "Nombre";
                chtInformacion.Series[0].YValueMembers = "Numero de Filas";
                chtInformacion.DataBind();
            }
        }
    }
}
