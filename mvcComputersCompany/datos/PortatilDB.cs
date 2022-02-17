﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace mvcComputersCompany.datos
{
    class PortatilDB
    {
        static ConnectionDB atrConnecionDB = new ConnectionDB();

        public string InsertarPortatil(string prmNroSerial, int prmNIT, string prmMarca, int prmCapDiscoDuroGB, string prmTipoDiscoDuro, int prmCapMemoriaRamGB, DateTime prmFechaEnsamble)
        {
            try
            {
                OracleCommand myCommand = new OracleCommand("ComputersCompany.prcRegistrarPortatil", atrConnecionDB.getMyConnection());
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
                atrConnecionDB.ComprobarConnection();
            }
        }

        public DataSet ConsultaPortatilesMarca(string prmNombre, string prmMarca) {

            try
            {
                OracleCommand myCommand = new OracleCommand("ComputersCompany.prcConsPortatilesMarca", atrConnecionDB.getMyConnection());
                myCommand.CommandType = CommandType.StoredProcedure;
                DataSet varDataSet = new DataSet();
                // Testing new parameters
                myCommand.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = prmNombre;
                myCommand.Parameters.Add("P_MARCA", OracleDbType.Varchar2).Value = prmMarca;
                myCommand.Parameters.Add("P_CURSOR_DATOS", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                
                OracleDataReader varReader = myCommand.ExecuteReader();
                
                OracleDataAdapter varAdapter = new OracleDataAdapter(myCommand);
                varAdapter.TableMappings.Add("Table", "Portatiles Por Marca");
                varAdapter.Fill(varDataSet);
                
                varReader.Close();
                return varDataSet;
            }
            catch (Exception)
            {
                return new DataSet();
            }
            finally
            {
                atrConnecionDB.ComprobarConnection();
            }
        }

    }
}
