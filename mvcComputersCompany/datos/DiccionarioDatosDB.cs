using System;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcDatabaseInfo.datos
{
    class DiccionarioDatosDB
    {
        static ConnectionDB atrConexionDB = new ConnectionDB();

        public double[] obtenerAlmacenamiento()
        {
            double[] vecAlmacenamiento = new double[2];
            try
            {
                atrConexionDB.CheckOpenConnection();
                OracleCommand myCommand = new OracleCommand("prcAlmacenamiento", atrConexionDB.getMyConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("Espacio Libre (MB)", OracleDbType.BinaryDouble, ParameterDirection.Output);
                myCommand.Parameters.Add("Espacio Ocupado (MB)", OracleDbType.BinaryDouble, ParameterDirection.Output);
                myCommand.ExecuteNonQuery();
                vecAlmacenamiento[0] = double.Parse(myCommand.Parameters["Espacio Libre (MB)"].Value.ToString());
                vecAlmacenamiento[1] = double.Parse(myCommand.Parameters["Espacio Ocupado (MB)"].Value.ToString());
                atrConexionDB.CheckClosedConnection();
                return vecAlmacenamiento;
            }
            catch (Exception)
            {
                vecAlmacenamiento[0] = -1;
                vecAlmacenamiento[1] = -1;
                return vecAlmacenamiento;
            }
        }
        public DataSet obtenerRestricciones()
        {
            try
            {
                atrConexionDB.CheckOpenConnection();
                OracleCommand myCommand = new OracleCommand("prcRestriccionesUsuarioActual", atrConexionDB.getMyConnection());
                myCommand.Parameters.Add("crRestricciones", OracleDbType.RefCursor, ParameterDirection.Output);
                myCommand.CommandType = CommandType.StoredProcedure;

                OracleDataAdapter myAdapter = new OracleDataAdapter(myCommand);
                DataSet varDataSet = new DataSet();
                myAdapter.Fill(varDataSet, "Restricciones");
                atrConexionDB.CheckClosedConnection();
                return varDataSet;
            }
            catch (Exception)
            {
                return new DataSet();
            }
        }

        public DataSet obtenerNroFilasParticion(string prmTableName) 
        {
            try
            {
                atrConexionDB.CheckOpenConnection();
                OracleCommand myCommand = new OracleCommand("NroFilasParticion", atrConexionDB.getMyConnection());
                myCommand.Parameters.Add("P_CURSOR_DATOS", OracleDbType.RefCursor, ParameterDirection.Output);
                myCommand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2, prmTableName, ParameterDirection.Input);
                myCommand.CommandType = CommandType.StoredProcedure;

                OracleDataAdapter myAdapter = new OracleDataAdapter(myCommand);
                DataSet varDataSet = new DataSet();
                myAdapter.Fill(varDataSet, "NroFilasParticion");
                atrConexionDB.CheckClosedConnection();
                return varDataSet;
            }
            catch (Exception)
            {
                return new DataSet();
            }
        }
        
    }
}
