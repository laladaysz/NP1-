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
    public partial class GenEntradasSaidas : Form
    {
        private EntradasSaidasController entradasSaidasController;
        public GenEntradasSaidas()
        {
            InitializeComponent();
            entradasSaidasController = new EntradasSaidasController();
            ConfigurarListView();
        }

        private void ConfigurarListView()
        {
            listaEntradasSaidas.View = System.Windows.Forms.View.Details;
            listaEntradasSaidas.FullRowSelect = true;
            listaEntradasSaidas.GridLines = true;

            listaEntradasSaidas.Columns.Add("ID", 50);                
            listaEntradasSaidas.Columns.Add("Motorista", 150);         
            listaEntradasSaidas.Columns.Add("Veículo", 150);           
            listaEntradasSaidas.Columns.Add("Vaga", 100);              
            listaEntradasSaidas.Columns.Add("Data Entrada", 150);      
            listaEntradasSaidas.Columns.Add("Data Saída", 150);       
        }

        private void attBtn_Click(object sender, EventArgs e)
        {
            List<EntradasSaidas> entradasSaidas = entradasSaidasController.GetEntradasSaidas();
            listaEntradasSaidas.Items.Clear();

            foreach (var entradaSaida in entradasSaidas)
            {
                ListViewItem item = new ListViewItem(entradaSaida.Id.ToString());
                item.SubItems.Add(entradaSaida.Motorista.Nome);  
                item.SubItems.Add(entradaSaida.Veiculo.Placa);   
                item.SubItems.Add(entradaSaida.Vaga.Numero.ToString()); 
                item.SubItems.Add(entradaSaida.Entrada.ToString("dd/MM/yyyy HH:mm:ss")); 
                item.SubItems.Add(entradaSaida.Saida.HasValue ? entradaSaida.Saida.Value.ToString("dd/MM/yyyy HH:mm:ss") : "Em aberto"); 

                listaEntradasSaidas.Items.Add(item);
            }
        }
    }
}
