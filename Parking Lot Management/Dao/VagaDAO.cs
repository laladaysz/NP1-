using MySql.Data.MySqlClient;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Lot_Management.Dao
{
    public class VagaDAO
    {
        private string connectionString = "server=localhost;database=parking_lot;user=root;password=";

        public void CadastrarVaga(Vaga vaga)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Vaga (Numero, Tipo, Disponivel, Localizacao) VALUES (@Numero, @Tipo, @Disponivel, @Localizacao)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Numero", vaga.Numero);
                cmd.Parameters.AddWithValue("@Tipo", vaga.Tipo);
                cmd.Parameters.AddWithValue("@Disponivel", vaga.Disponivel);
                cmd.Parameters.AddWithValue("@Localizacao", vaga.Localizacao);
                
                cmd.ExecuteNonQuery();
            }
        }

        public List<Vaga> GetAllVagas()
        {
            List<Vaga> vagas = new List<Vaga>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Vaga";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vaga vaga = new Vaga
                    {
                        Id = (int)reader["Id"],
                        Numero = (string)reader["Numero"],
                        Tipo = (string)reader["Tipo"],
                        Disponivel = (bool)reader["Disponivel"],                        
                        Localizacao = (string)reader["Localizacao"]
                    };

                    vagas.Add(vaga);
                }
            }
            return vagas;
        }

        public void DeleteVaga(int id)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Vaga WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        public Vaga GetVagaById(int id)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Vaga WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Vaga vaga = new Vaga()
                    {
                        Id = (int)reader["Id"],
                        Numero = (string)reader["Numero"],
                        Tipo = (string)reader["Tipo"],
                        Disponivel = (bool)reader["Disponivel"],
                        Localizacao = (string)reader["Localizacao"]
                    };
                    con.Close();
                    return vaga;
                }

                return null;
            }
        }

        public void AtualizarVaga(Vaga vaga)
        {
            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE Vaga SET Numero = @Numero, Tpo = @Tipo, Localizacao = @Loalizacao WHERE Id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", vaga.Id);
                cmd.Parameters.AddWithValue("@Numero", vaga.Localizacao);
                cmd.Parameters.AddWithValue("@Tipo", vaga.Tipo);
                cmd.Parameters.AddWithValue("@Localizacao", vaga.Localizacao);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
