using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    public class ConnectionDB
    {
        //private static string atrUserDB = "ComputersCompany";
        //private static string atrPasswordDB = "bddarwin";

        private static string atrUserDB; //= "BD2";
        private static string atrPasswordDB; //= "AnteDatabase";

        private static string atrConnectionDB; //= "Data Source = localhost; User ID = " + atrUserDB + "; Password=" + atrPasswordDB + ";";
        private static OracleConnection myConnection; //= new OracleConnection(@atrConnectionDB);

        public static void conectar()
        {
            atrConnectionDB = "Data Source = localhost; User ID = " + atrUserDB + "; Password=" + atrPasswordDB + ";";
            myConnection = new OracleConnection(@atrConnectionDB);
        }
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
        public void ComprobarConnection()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }
        public OracleConnection getMyConnection()
        {
            return myConnection;
        }
        public static void setUser(string prmUser)
        {
            atrUserDB = prmUser;
        }
        public static void setPassword(string prmPassword)
        {
            atrPasswordDB = prmPassword;
        }
    }
}
