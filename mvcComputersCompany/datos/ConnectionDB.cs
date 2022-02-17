using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace mvcComputersCompany.datos
{
    public class ConnectionDB
    {
        //private static string atrUserDB = "ComputersCompany";
        //private static string atrPasswordDB = "bddarwin";

        private static string atrUserDB = "BD2";
        private static string atrPasswordDB = "AnteDatabase";

        private static string atrConnectionDB = "Data Source = localhost; User ID = " + atrUserDB + "; Password=" + atrPasswordDB + ";";
        private static OracleConnection myConnection = new OracleConnection(@atrConnectionDB);

        public static string getStatus()
        {
            try
            {
                myConnection.Open();
                return "Se conecto a la base de datos correctamente";
            }
            catch (Exception e)
            {
                return "ERROR: " + e.Message;
            }
        }

        public OracleConnection getMyConnection() 
        {
            myConnection.Open();
            return myConnection;
        }

        public void ComprobarConnection()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }
    }
}
