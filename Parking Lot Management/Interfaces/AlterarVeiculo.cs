using Parking_Lot_Management.Controller;
using Parking_Lot_Management.Model;
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
    public partial class AlterarVeiculo : Form
    {
        private VeiculoController veiculoController;
        private int veiculoId;
        public AlterarVeiculo(Veiculo veiculo)
        {
            InitializeComponent();
            veiculoController = new VeiculoController();

            veiculoId = veiculo.Id;
            placaTxt.Text = veiculo.Placa;
            modeloTxt.Text = veiculo.Modelo;
            corTxt.Text = veiculo.Cor;
            PreencherComboBoxMotoristas(veiculo.MotoristaId);
        }

        private void PreencherComboBoxMotoristas(int motoristaAtualId)
        {
            try
            {
                MotoristaController motoristaController = new MotoristaController();

                List<Motorista> motoristas = motoristaController.GetAllMotoristas();

                motoristaBox.DataSource = motoristas;
                motoristaBox.DisplayMember = "Nome";  
                motoristaBox.ValueMember = "Id";     

                motoristaBox.SelectedValue = motoristaAtualId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar motoristas: " + ex.Message);
            }
        }
        

        private void saveBtn_Click(object sender, EventArgs e) {

            try
            {
                int motoristaSelecionadoId = (int)motoristaBox.SelectedValue;
                veiculoController.AtualizarVeiculo(veiculoId, placaTxt.Text, modeloTxt.Text, corTxt.Text, motoristaSelecionadoId);

                MessageBox.Show("Veículo atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar veículo: " + ex.Message);
            }

        }

    }
}
