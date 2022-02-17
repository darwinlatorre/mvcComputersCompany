using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcComputersCompany.datos;

namespace mvcComputersCompany.logica
{
    class Empresa
    {
        static EmpresaDB atrEmpresa = new EmpresaDB();
        public static string RegistrarEmpresa(int prmNit, string prmNombre, DateTime prmFechaCreacion) 
        {
            return atrEmpresa.InsertarEmpresa(prmNit, prmNombre, prmFechaCreacion);
        }
    }
}
