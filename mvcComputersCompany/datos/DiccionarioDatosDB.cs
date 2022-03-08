using System;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    class DiccionarioDatosDB
    {
        static ConnectionDB atrConexionDB = new ConnectionDB();

        public DataSet obtenerAlmacenamiento()
        {
            DataSet varDataSet = new DataSet();
            float varEspacioLibreMB = 0;
            float varEspacioOcupadoMB = 0;

            atrConexionDB.CheckOpenConnection();
            OracleCommand myCommand = new OracleCommand(ConnectionDB.getUser() + ".prcAlmacenamiento", atrConexionDB.getMyConnection());
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add("Espacio Libre (MB)", OracleDbType.BinaryFloat, varEspacioLibreMB, ParameterDirection.Output);
            myCommand.Parameters.Add("Espacio Ocupado (MB)", OracleDbType.BinaryFloat, varEspacioOcupadoMB, ParameterDirection.Output);
            OracleDataAdapter myAdapter = new OracleDataAdapter(myCommand);
            myAdapter.Fill(varDataSet, "Espacio");
            myCommand.ExecuteNonQuery();
            atrConexionDB.CheckClosedConnection();
            return varDataSet;
        }
    }
}
