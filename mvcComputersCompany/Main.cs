using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mvcComputersCompany
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        #region Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Arrastar ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
