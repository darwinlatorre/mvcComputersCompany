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
            chtAlmacenamiento.DataSource = atrDiccionarioDatos.obtenerNroFilasParticion(txtbTabla.Text);
            chtAlmacenamiento.Series[0].XValueMember = "Nombre";
            chtAlmacenamiento.Series[0].YValueMembers = "Numero de Filas";
            chtAlmacenamiento.DataBind();
        }
    }
}
