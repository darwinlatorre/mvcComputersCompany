using System;
using System.Data;
using mvcComputersCompany.datos;

namespace mvcComputersCompany.logica
{
    class Portatil
    {
        PortatilDB atrPortatil = new PortatilDB();
        public string RegistrarPortatil(string prmNroSerial, int prmNIT, string prmMarca, int prmCapDiscoDuroGB, string prmTipoDiscoDuro, int prmCapMemoriaRamGB, DateTime prmFechaEnsamble)
        {
            return atrPortatil.InsertarPortatil(prmNroSerial, prmNIT, prmMarca, prmCapDiscoDuroGB, prmTipoDiscoDuro, prmCapMemoriaRamGB, prmFechaEnsamble);
        }

        public DataSet ConsultarPotatilxMarca(string prmNombreEmpresa, string prmMarcaPortatil) 
        {
            DataSet varConjuntoDatosConsulta = new DataSet();
            varConjuntoDatosConsulta = atrPortatil.ConsultaPortatilesMarca(prmNombreEmpresa, prmMarcaPortatil);
            return varConjuntoDatosConsulta;
        }
    }
}
