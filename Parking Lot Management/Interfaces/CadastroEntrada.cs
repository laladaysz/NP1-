using Parking_Lot_Management.Controller;
using Parking_Lot_Management.Model;
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
    public partial class CadastroEntrada : Form
    {
        private MotoristaController motoristaController;
        private VeiculoController veiculoController;
        private VagaController vagaController;
        private EntradasSaidasController entradasSaidasController;
        public CadastroEntrada()
        {
            InitializeComponent();
            motoristaController = new MotoristaController();
            veiculoController = new VeiculoController();
            vagaController = new VagaController();
            entradasSaidasController = new EntradasSaidasController();

            CarregarMotoristasComboBox();
            CarregarVagasComboBox();
        }

        private void CarregarMotoristasComboBox()
        {
            var motoristas = motoristaController.GetAllMotoristas();
            motoComboBox.DataSource = motoristas;
            motoComboBox.DisplayMember = "Nome";
            motoComboBox.ValueMember = "Id";

            if (motoristas.Count > 0)
            {
                motoComboBox.SelectedIndex = 0;  
            }
        }

        private void CarregarVagasComboBox()
        {
            var vagas = vagaController.GetVagasDisponiveis();
            vagaComboBox.DataSource = vagas;
            vagaComboBox.DisplayMember = "Numero";
            vagaComboBox.ValueMember = "Id";
        }

        private void motoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motoComboBox.SelectedItem != null)
            {

                Motorista motoristaSelecionado = (Motorista)motoComboBox.SelectedItem;
                int motoristaId = motoristaSelecionado.Id;

                CarregarVeiculosComboBox(motoristaId);

            }
        }

        private void CarregarVeiculosComboBox(int motoristaId)
        {
            var veiculos = veiculoController.GetVeiculosByMotorista(motoristaId);
            carroComboBox.DataSource = veiculos;
            carroComboBox.DisplayMember = "Placa";
            carroComboBox.ValueMember = "Id";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resgiterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int motoristaId = (int)motoComboBox.SelectedValue;
                int veiculoId = (int)carroComboBox.SelectedValue;
                int vagaId = (int)vagaComboBox.SelectedValue;

                entradasSaidasController.CadastrarEntrada(motoristaId, veiculoId, vagaId);
                vagaController.OcuparVaga(vagaId);
                MessageBox.Show("Entrada registrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar entrada: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }
    }
}
