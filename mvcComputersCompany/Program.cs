using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using mvcComputersCompany.logica;

namespace mvcComputersCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Portatil varPortatil = new Portatil();

            DataSet varTest = new DataSet();

            varTest = varPortatil.ConsultarPotatilxMarca("Tauret Gaming", "Asus");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
