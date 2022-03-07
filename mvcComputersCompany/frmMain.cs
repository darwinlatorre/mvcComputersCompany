﻿using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using mvcComputersCompany.datos;

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
        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.Size = new System.Drawing.Size(25, 25);
            btnSalir.Location = new System.Drawing.Point(768, 7);
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Size = new System.Drawing.Size(20, 20);
            btnSalir.Location = new System.Drawing.Point(768, 12);
        }
        #endregion
        #region Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.Size = new System.Drawing.Size(25, 25);
            btnMinimizar.Location = new System.Drawing.Point(740, 7);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.Size = new System.Drawing.Size(20, 20);
            btnMinimizar.Location = new System.Drawing.Point(740, 12);
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
        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        #region Menu lateral
        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAlmacenamiento>();
            btnAlmacenamiento.BackColor = Color.FromArgb(81, 96, 90);
        }
        private void btnListaRestricciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmListaRestricciones>();
            btnListaRestricciones.BackColor = Color.FromArgb(81, 96, 90);
        }
        private void btnInformacionTabla_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmInformacionTabla>();
            btnInformacionTabla.BackColor = Color.FromArgb(81, 96, 90);
        }
        #endregion
        #region Procedimientos
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlForms.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.BackColor = Color.FromArgb(228, 242, 231);
                pnlForms.Controls.Add(formulario);
                pnlForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["frmAlmacenamiento"] == null)
                btnAlmacenamiento.BackColor = Color.FromArgb(45, 62, 64);

            if (Application.OpenForms["frmListaRestricciones"] == null)
                btnListaRestricciones.BackColor = Color.FromArgb(45, 62, 64);

            if (Application.OpenForms["frmInformacionTabla"] == null)
                btnInformacionTabla.BackColor = Color.FromArgb(45, 62, 64);
        }
        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConnectionDB.setUser(txbUsuario.Text);
            ConnectionDB.setPassword(txbPassword.Text);
            ConnectionDB.conectar();
            if (ConnectionDB.boolStatus())
            {
                btnAlmacenamiento.Enabled = true;
                btnListaRestricciones.Enabled = true;
                btnInformacionTabla.Enabled = true;
                txbUsuario.Enabled = false;
                txbPassword.Enabled = false;
                btnConectar.Enabled = false;
            }
            lblStatus.Text = ConnectionDB.stringStatus();
        }
        #endregion
    }
}
