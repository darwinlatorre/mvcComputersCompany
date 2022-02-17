using System;
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
