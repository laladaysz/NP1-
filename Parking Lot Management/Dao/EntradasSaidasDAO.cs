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

        public List<EntradasSaidas> GetAllEntradasSaidas()
        {
            List<EntradasSaidas> entradas = new List<EntradasSaidas>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Consulta SQL para carregar as entradas e saídas com todos os dados necessários
                string query = @"
            SELECT 
                es.Id,
                es.MotoristaId,
                m.Nome AS MotoristaNome,
                es.VeiculoId,
                v.Placa AS VeiculoPlaca,
                es.VagaId,
                va.Numero AS VagaNumero,
                es.Entrada,
                es.Saida,
                es.Pago
            FROM EntradasSaidas es
            JOIN Motorista m ON es.MotoristaId = m.Id
            JOIN Veiculo v ON es.VeiculoId = v.Id
            JOIN Vaga va ON es.VagaId = va.Id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EntradasSaidas entradaSaida = new EntradasSaidas
                    {
                        Id = (int)reader["Id"],
                        MotoristaId = (int)reader["MotoristaId"], 
                        VeiculoId = (int)reader["VeiculoId"],
                        VagaId = (int)reader["VagaId"],
                        Entrada = (DateTime)reader["Entrada"],
                        Saida = reader.IsDBNull(reader.GetOrdinal("Saida"))
                            ? (DateTime?)null
                            : (DateTime)reader["Saida"],
                        Pago = (bool)reader["Pago"], 

                        
                        Motorista = new Motorista
                        {
                            Id = (int)reader["MotoristaId"],
                            Nome = (string)reader["MotoristaNome"]
                        },
                        Veiculo = new Veiculo
                        {
                            Id = (int)reader["VeiculoId"],
                            Placa = (string)reader["VeiculoPlaca"]
                        },
                        Vaga = new Vaga
                        {
                            Id = (int)reader["VagaId"],
                            Numero = (string)reader["VagaNumero"]
                        }
                    };

                    entradas.Add(entradaSaida);
                }
                conn.Close();
            }
            return entradas;
        }

        public void ExcluirRegistro(int Id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string deleteVeiculosQuery = "DELETE FROM EntradasSaidas WHERE Id = @Id";
                MySqlCommand deleteVeiculosCmd = new MySqlCommand(deleteVeiculosQuery, conn);
                deleteVeiculosCmd.Parameters.AddWithValue("@Id", Id);
                deleteVeiculosCmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
