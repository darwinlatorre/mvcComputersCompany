using System;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    class PortatilDB
    {
        static ConnectionDB atrConexionDB = new ConnectionDB();

        public string InsertarPortatil(string prmNroSerial, int prmNIT, string prmMarca, int prmCapDiscoDuroGB, string prmTipoDiscoDuro, int prmCapMemoriaRamGB, DateTime prmFechaEnsamble)
        {
            try
            {
                atrConexionDB.CheckOpenConnection();
                OracleCommand myCommand = new OracleCommand("ComputersCompany.prcRegistrarPortatil", atrConexionDB.getMyConnection());
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.Add("P_NRO_SERIAL", OracleDbType.Varchar2, prmNroSerial, ParameterDirection.Input);
                myCommand.Parameters.Add("P_NIT", OracleDbType.Int64, prmNIT, ParameterDirection.Input);
                myCommand.Parameters.Add("P_MARCA", OracleDbType.Varchar2, prmMarca, ParameterDirection.Input);
                myCommand.Parameters.Add("P_CAP_DISCO_DURO_GB", OracleDbType.Int64, prmCapDiscoDuroGB, ParameterDirection.Input);
                myCommand.Parameters.Add("P_TIPO_DISCO_DURO", OracleDbType.Varchar2, prmTipoDiscoDuro, ParameterDirection.Input);
                myCommand.Parameters.Add("P_CAP_MEMORIA_RAM_GB", OracleDbType.Int64, prmCapMemoriaRamGB, ParameterDirection.Input);
                myCommand.Parameters.Add("P_FECHA_ENSAMBLE", OracleDbType.Date, prmFechaEnsamble, ParameterDirection.Input);
                
                myCommand.ExecuteNonQuery();
                return "Se ha registrado el portatil";
            }
            catch (Exception)
            {
                return "No se ha registrado el portatil";
            }
            finally
            {
                atrConexionDB.CheckClosedConnection();
            }
        }

        public DataSet ConsultaPortatilesMarca(string prmNombreEmpresa, string prmMarcaPortatil) {

            try
            {
                atrConexionDB.CheckOpenConnection();
                OracleCommand myCommand = new OracleCommand("ComputersCompany.prcConsPortatilesMarca", atrConexionDB.getMyConnection());

                myCommand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2, prmNombreEmpresa, ParameterDirection.Input);
                myCommand.Parameters.Add("P_MARCA", OracleDbType.Varchar2, prmMarcaPortatil, ParameterDirection.Input);
                myCommand.Parameters.Add("P_CURSOR_DATOS", OracleDbType.RefCursor, ParameterDirection.Output);
                myCommand.CommandType = CommandType.StoredProcedure;
                
                OracleDataAdapter varAdapter = new OracleDataAdapter(myCommand);
                DataSet varDataSet = new DataSet();
                varAdapter.Fill(varDataSet, "PortatilesPorMarca");
                return varDataSet;
            }
            catch (Exception)
            {
                return new DataSet();
            }
            finally
            {
                atrConexionDB.CheckClosedConnection();
            }
        }

    }
}
