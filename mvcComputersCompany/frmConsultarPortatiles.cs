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

            string varNombreEmpresa = txbNombreEmpresa.Text;
            string varMarcaPortatil = txbMarcaPortatil.Text;

            

            //txbNombreEmpresa
            //txbMarcaPortatil
        }
    }
}
