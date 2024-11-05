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
    public partial class CadastroMotoristas : Form
    {
        private MotoristaController motoristaController;

        public CadastroMotoristas()
        {
            InitializeComponent();
            motoristaController = new MotoristaController();
        }

        private void cadBtn_Click(object sender, EventArgs e)
        {
            string nome = nomeTxt.Text;
            string email = emailTxt.Text;
            string telefone = telTxt.Text;
            bool ativo = true;

            try
            {
                motoristaController.CadastrarMotorista(nome, email, telefone, ativo);
                MessageBox.Show("Motorista cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar motorista: {ex.Message}");
            }
        }
    }
}
