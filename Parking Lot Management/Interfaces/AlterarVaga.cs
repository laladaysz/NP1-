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
    public partial class AlterarVaga : Form
    {
        private VagaController vagaController;
        int vagaId;
        public AlterarVaga(Vaga vaga)
        {
            InitializeComponent();
            vagaController = new VagaController();

            vagaId = vaga.Id;
            numTxt.Text = vaga.Numero;
            tipoTxt.Text = vaga.Tipo;
            locTxt.Text = vaga.Localizacao;
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {

            try
            {   
        
                string numero = numTxt.Text;
                string tipo = tipoTxt.Text;
                string loc = locTxt.Text;
                vagaController.AtualizarVaga(vagaId, numero, tipo, loc);

                MessageBox.Show("Vaga atualizada com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar vaga: " + ex.Message);
            }

        }
    }
}
