using System;
using System.Windows.Forms;
using mvcComputersCompany.logica;

namespace mvcComputersCompany
{
    public partial class frmRegistrarEmpresa : Form
    {
        public frmRegistrarEmpresa()
        {
            InitializeComponent();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                lblRegistroEmpresa.Text = Empresa.RegistrarEmpresa(int.Parse(txbNit.Text), txbNombre.Text, dtpFechaCreacion.Value);
                lblRegistroEmpresa.Visible = true;
            }
            catch (Exception a)
            {
                lblRegistroEmpresa.Text = "ERROR: " + a.Message;
                lblRegistroEmpresa.Visible = true;
            }
        }
    }
}
