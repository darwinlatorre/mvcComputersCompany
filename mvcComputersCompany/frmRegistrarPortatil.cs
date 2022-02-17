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
                lblRegistroPortatil.Text = Portatil.RegistrarPortatil(txbSerial.Text, int.Parse(txbNit.Text), cbMarca.Text, int.Parse(txbCapacidadDisco.Text), cbTipoDisco.Text, int.Parse(txbCapacidadRam.Text), dtpFechaEnsamblaje.Value);
                lblRegistroPortatil.Visible = true;
            }
            catch (Exception a)
            {
                lblRegistroPortatil.Text = "ERROR: " + a.Message;
                lblRegistroPortatil.Visible = true;
            }
        }
    }
}
