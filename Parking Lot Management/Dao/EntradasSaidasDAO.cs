using MySql.Data.MySqlClient;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Dao
{
    public class EntradasSaidasDAO
    {
        private string connectionString = "server=localhost;database=parking_lot;user=root;password=";

        public void CadastrarEntrada(EntradasSaidas entrada)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO EntradasSaidas (VeiculoId, VagaId, MotoristaId, Entrada, Pago) VALUES (@VeiculoId, @VagaId, @MotoristaId, @Entrada, @Pago)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@VeiculoId", entrada.VeiculoId);
                cmd.Parameters.AddWithValue("@VagaId", entrada.VagaId);
                cmd.Parameters.AddWithValue("@MotoristaId", entrada.MotoristaId);
                cmd.Parameters.AddWithValue("@Entrada", entrada.Entrada);
                cmd.Parameters.AddWithValue("@Pago", entrada.Pago);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
