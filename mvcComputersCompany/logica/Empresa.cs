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
        EmpresaDB atrEmpresa = new EmpresaDB();
        public string RegistrarEmpresa(int prmNit, string prmNombre, DateTime prmFechaCreacion) 
        {
            return atrEmpresa.InsertarEmpresa(prmNit, prmNombre, prmFechaCreacion);
        }
    }
}
