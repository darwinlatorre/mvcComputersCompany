using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
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

        public DataSet ConsultarPotatilxMarca(string prmNombre, string prmMarca) 
        {
            return atrPortatil.ConsultaPortatilesMarca(prmNombre, prmMarca);
        }
    }
}
