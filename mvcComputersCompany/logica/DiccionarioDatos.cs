using System;
using System.Data;
using mvcComputersCompany.datos;

namespace mvcComputersCompany.logica
{
    class DiccionarioDatos
    {
        static DiccionarioDatosDB atrDiccionarioDatosDB = new DiccionarioDatosDB();

        public DataSet obtenerAlmacenamiento()
        {
            return atrDiccionarioDatosDB.obtenerAlmacenamiento();
        }
    }
}
