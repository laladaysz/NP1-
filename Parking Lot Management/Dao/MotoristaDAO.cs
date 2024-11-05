using MySql.Data.MySqlClient;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Dao
{
    public class MotoristaDao
    {
        private string connectionString = "server=localhost;database=parking_lot;user=root;password=";

        public void cadastrarMotorista(Motorista motorista)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Motorista (Nome, Email, Telefone, Ativado) VALUES (@Nome, @Email, @Telefone, @Ativado)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nome", motorista.Nome);
                cmd.Parameters.AddWithValue("@Email", motorista.Email);
                cmd.Parameters.AddWithValue("@Telefone", motorista.Telefone);
                cmd.Parameters.AddWithValue("@Ativado", motorista.Ativo);
                cmd.ExecuteNonQuery();
            }
        }

        public Motorista BuscarMotoristaPorId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Motorista WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Motorista motorista = new Motorista()
                    {
                        Id = (int)reader["Id"],
                        Nome = (string)reader["Nome"],
                        Email = (string)reader["Email"],
                        Telefone = (string)reader["Telefone"],
                        Ativo = (bool)reader["Ativo"]
                    };
                    return motorista;
                }

                return null;
            }
        }
            public List<Motorista> GetAllMotorista()
            {
                List<Motorista> motoristas = new List<Motorista>();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Motorista";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Motorista motorista = new Motorista
                        {
                            Id = (int)reader["Id"],
                            Nome = (string)reader["Nome"],
                            Email = (string)reader["Email"],
                            Telefone = (string)reader["Telefone"],
                            Ativo = (bool)reader["Ativo"]
                        };

                        motoristas.Add(motorista);
                    }
                }
                return motoristas;
            }


        public void ExcluirMotorista(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Motorista WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }




    }
}
