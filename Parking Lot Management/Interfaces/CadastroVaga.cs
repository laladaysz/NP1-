using Parking_Lot_Management.Controller;
using Parking_Lot_Management.View;
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
    public partial class CadastroVaga : Form
    {
        private VagaController controller;
        public CadastroVaga()
        {
            controller = new VagaController();
            InitializeComponent();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            string num = numTxt.Text;
            string tipo = tipoTxt.Text;
            string loc = locTxt.Text;

            try
            {
                controller.CadastrarVaga(num, tipo, loc);

                numTxt.Text = "";
                tipoTxt.Text = "";
                locTxt.Text = "";

                MessageBox.Show("Vaga cadastrada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar vaga: {ex.Message}");
            }

        }

        private void vltBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }
    }
}
