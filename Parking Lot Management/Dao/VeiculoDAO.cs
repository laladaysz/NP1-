using MySql.Data.MySqlClient;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Dao
{
    public class VeiculoDAO
    {
        private string connectionString = "server=localhost;database=parking_lot;user=root;password=";

        public void CadastrarVeiculo(Veiculo veiculo, int idMotorista)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Veiculo (Placa, Modelo, Cor, MotoristaId) VALUES (@Placa, @Modelo, @Cor, @MotoristaId)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Placa", veiculo.Placa);
                cmd.Parameters.AddWithValue("@Modelo", veiculo.Modelo);
                cmd.Parameters.AddWithValue("@Cor", veiculo.Cor);
                cmd.Parameters.AddWithValue("@MotoristaId", idMotorista);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Veiculo> GetAllVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Veiculo";
                MySqlCommand cmd = new MySqlCommand(query, con);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Veiculo veiculo = new Veiculo
                    {
                        Id = (int)reader["Id"],
                        Placa = (string)reader["Placa"],
                        Modelo = (string)reader["Modelo"],
                        Cor = (string)reader["Cor"],
                        MotoristaId = (int)reader["MotoristaId"]
                    };

                    veiculos.Add(veiculo);
                }
                con.Close();
            }
            return veiculos;
        }

        public Veiculo GetVeiculoById(int id)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Veiculo WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Veiculo veiculo = new Veiculo()
                    {
                        Id = (int)reader["Id"],
                        Placa = (string)reader["Nome"],
                        Modelo = (string)reader["Email"],
                        Cor = (string)reader["Telefone"],
                        MotoristaId = (int)reader["MotoristaId"]
                    };
                    con.Close();
                    return veiculo;
                }

                return null;
            }
        }

        public void DeleteVeiculo(int id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Veiculo WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        public List<Veiculo> GetVeiculoByMotorista(int MotoristaId)
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Veiculo WHERE MotoristaId = @MotoristaId";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Parameters.AddWithValue("@MotoristaId", MotoristaId);
             
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Veiculo veiculo = new Veiculo
                    {
                        Id = (int)reader["Id"],
                        Placa = (string)reader["Placa"],
                        Modelo = (string)reader["Modelo"],
                        Cor = (string)reader["Cor"],
                        MotoristaId = (int)reader["IdMotorista"]
                    };

                    veiculos.Add(veiculo);
                }
                conn.Close();
            }
            return veiculos;

        }


    }
}
    

