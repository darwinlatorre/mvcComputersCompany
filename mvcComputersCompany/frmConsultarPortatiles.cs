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
    public partial class frmConsultarPortatiles : Form
    {
        public frmConsultarPortatiles()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Portatil varPortatil = new Portatil();
            try
            {
                dgvConsulta.DataSource = varPortatil.ConsultarPotatilxMarca(txbNombreEmpresa.Text, txbMarcaPortatil.Text);
                dgvConsulta.DataMember = "PortatilesPorMarca";
            }
            catch (Exception a)
            {
                lblRespuestaConsulta.Text = "Error: " + a.Message;
                lblRespuestaConsulta.Visible = true;
            }
        }
    }
}
