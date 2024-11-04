using Parking_Lot_Management.Controller;
using Parking_Lot_Management.Model;
using Parking_Lot_Management.View;

namespace Parking_Lot_Management
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = emailTxtBox.Text;
            string senha = senhaTxtBox.Text;

            UsuarioController usuarioController = new UsuarioController();

            Usuario usuario = usuarioController.AutenticarUsuario(email, senha);

            if (usuario != null)
            {
                MessageBox.Show("Login realizado com sucesso! Seja bem-vindo, " + usuario.Nome);
                this.Hide();

                if (usuario.Role == "ADMIN")
                {
                    this.Hide();
                    HomeAdmin homeAdmin = new HomeAdmin();
                    homeAdmin.Show();

                }

            }
            else
            {
                MessageBox.Show("Email ou senha incorretos. Tente novamente.");
            }
        }

        private void cadBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

        }
    }
}
