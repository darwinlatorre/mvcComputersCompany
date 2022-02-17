using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace mvcComputersCompany.datos
{
    public class ConnectionDB
    {
        #region attributes

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
        public static string stringStatus()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
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
        public static bool boolStatus()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
            try
            {
                myConnection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void CheckClosedConnection()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }
        public void CheckOpenConnection()
        {
            if (myConnection.State == ConnectionState.Closed)
            {
                myConnection.Open();
            }
        }
        public OracleConnection getMyConnection()
        {
            return myConnection;
        }

        #endregion
        #region Setters
        public static void setUser(string prmUser)
        {
            atrUserDB = prmUser;
        }
        public static string getUser()
        {
            return atrUserDB;
        }
        public static void setPassword(string prmPassword)
        {
            atrPasswordDB = prmPassword;
        }
        public static void Conectar()
        {
            atrConnectionDB = "Data Source = localhost; User ID = " + atrUserDB + "; Password=" + atrPasswordDB + ";";
            myConnection = new OracleConnection(@atrConnectionDB);
        }
        #endregion
    }
}
