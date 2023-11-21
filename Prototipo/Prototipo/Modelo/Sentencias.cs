using System;
using System.Data;
using System.Data.Odbc;

namespace Modelo_PrototipoMenu
{
    public class Sentencias
    {
        private Conexion con;



        public Sentencias()
        {
            con = new Conexion();
        }
        public void InsertarReserva(string asientos, string subtotal, string factura) { 
            using (OdbcConnection connection = con.AbrirConexion())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO Reservaciones (idReservaciones, fkAsientos, subTotalAsiento, fkFactura) VALUES (?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@fkAsientos", asientos);
                                cmd.Parameters.AddWithValue("@subTotalAsiento", subtotal);
                                cmd.Parameters.AddWithValue("@fkFactura", factura);


                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar el registro: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
