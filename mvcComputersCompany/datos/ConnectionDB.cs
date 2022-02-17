using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    public class ConnectionDB
    {
        private static string atrUserDB = "ComputersCompany";
        private static string atrPasswordDB = "bddarwin";
        private static string atrConnectionDB = @"Data Source = localhost; User ID = " + atrUserDB + "; Password=" + atrPasswordDB + ";";

        private static OracleConnection myConnection = new OracleConnection(atrConnectionDB);

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
