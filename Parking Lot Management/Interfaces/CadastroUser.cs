using Parking_Lot_Management.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Management.Interfaces
{
    public partial class CadastroUser : Form
    {
        private UsuarioController usuarioController;
        public CadastroUser()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void cadBtn_Click(object sender, EventArgs e)
        {
            string nome = nomeTxt.Text;
            string email = emailTxt.Text;
            string senha = senhaTxt.Text;
            string role = "User"; 
            bool ativado = true;

            try
            {
                
                usuarioController.CadastrarUsuario(nome, email, senha, role, ativado);
                MessageBox.Show("Usuário cadastrado com sucesso!");
                this.Close();
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}");
            }
        }
    }
}
