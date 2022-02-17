using System;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    class EmpresaDB
    {
        static ConnectionDB atrConnecionDB = new ConnectionDB();

        public string InsertarEmpresa(int prmNit, string prmNombre, DateTime prmFechaCreacion) {
            try
            {
                OracleCommand myCommand = new OracleCommand(ConnectionDB.getUser() + ".prcRegistrarEmpresa", atrConnecionDB.getMyConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                
                myCommand.Parameters.Add("P_NIT", OracleDbType.Int64, prmNit, ParameterDirection.Input);
                myCommand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2, prmNombre, ParameterDirection.Input);
                myCommand.Parameters.Add("P_FECHA_CREACION", OracleDbType.Date, prmFechaCreacion, ParameterDirection.Input);
                
                myCommand.ExecuteNonQuery();
                return "Se ha registrado la empresa";
            }
            catch (Exception e)
            {
                return "ERROR: " + e.Message;
            }
            finally 
            {
                atrConnecionDB.ComprobarConnection();
            }
        }
    }
}
