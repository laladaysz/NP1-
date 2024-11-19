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
    public partial class GenVagas : Form
    {
        private VagaController controller;
        public GenVagas()
        {
            controller = new VagaController();
            InitializeComponent();
            CofigurarListView();
        }
        private void CofigurarListView()
        {
            listaVagas.View = System.Windows.Forms.View.Details;
            listaVagas.FullRowSelect = true;
            listaVagas.GridLines = true;

            listaVagas.Columns.Add("ID", 50);
            listaVagas.Columns.Add("Número", 150);
            listaVagas.Columns.Add("Tipo", 200);
            listaVagas.Columns.Add("Disponibilidade", 100);
            listaVagas.Columns.Add("Localização", 80);

        }
        private void attBtn_Click(object sender, EventArgs e)
        {
            List<Vaga> vagas = controller.GetAllVagas();
            listaVagas.Items.Clear();

            foreach (var vaga in vagas)
            {
                ListViewItem item = new ListViewItem(vaga.Id.ToString());
                item.SubItems.Add(vaga.Numero);
                item.SubItems.Add(vaga.Tipo);
                item.SubItems.Add(vaga.Disponivel ? "Sim" : "Não");
                item.SubItems.Add(vaga.Localizacao);

                listaVagas.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaVagas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaVagas.SelectedItems[0];
                int vagaId = int.Parse(selectedItem.Text);
                controller.DeletarVaga(vagaId);

                attBtn_Click(sender, e);

                MessageBox.Show("Vaga excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione uma vaga para excluir.");
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
