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
    }
}
