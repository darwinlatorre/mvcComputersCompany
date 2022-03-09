using System;
using System.Data;
using mvcDatabaseInfo.datos;

namespace mvcDatabaseInfo.logica
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

        public DataSet obtenerNroFilasParticion(string prmTableName) 
        {
            return atrDiccionarioDatosDB.obtenerNroFilasParticion(prmTableName);
        }
    }
}
