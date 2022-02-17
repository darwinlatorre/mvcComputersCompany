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
    public partial class frmRegistrarPortatil : Form
    {
        public frmRegistrarPortatil()
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
                Portatil.RegistrarPortatil(txbSerial.Text, int.Parse(txbNit.Text), cbMarca.Text, int.Parse(txbCapacidadDisco.Text), cbTipoDisco.Text, int.Parse(txbCapacidadRam.Text), dtpFechaEnsamblaje.Value);
                btnRegistrar.Visible = false;
                lblRegistrar.Text = "Registro satisfactorio";
                lblRegistrar.Visible = true;
            }
            catch (Exception a)
            {
                lblRegistrar.Text = "ERROR: " + a.Message;
                lblRegistrar.Visible = true;
            }
        }
    }
}
