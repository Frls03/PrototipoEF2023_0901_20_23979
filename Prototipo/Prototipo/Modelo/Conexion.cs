﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;


namespace Modelo_PrototipoMenu
{
    class Conexion
    {
        private string connectionString;

        public Conexion()
        {
            // Asignar el nombre de la base de datos directamente
            string nombreBase = "HotelSConexion";
            connectionString = $"Dsn={nombreBase}";
        }

        public OdbcConnection AbrirConexion()
        {
            OdbcConnection conn = new OdbcConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (OdbcException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                return null;
            }
        }

        public void CerrarConexion(OdbcConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
