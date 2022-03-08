using System;
using System.Data;
using mvcComputersCompany.datos;

namespace mvcComputersCompany.logica
{
    class DiccionarioDatos
    {
        static DiccionarioDatosDB atrDiccionarioDatosDB = new DiccionarioDatosDB();

        public double[] obtenerAlmacenamiento()
        {
            return atrDiccionarioDatosDB.obtenerAlmacenamiento();
        }

        public DataSet obtenerRestricciones()
        {
            return atrDiccionarioDatosDB.obtenerRestricciones();
        }
    }
}
