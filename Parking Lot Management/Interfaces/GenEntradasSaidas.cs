﻿using Parking_Lot_Management.Controller;
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
    public partial class GenEntradasSaidas : Form
    {
        private EntradasSaidasController entradasSaidasController;
        private VagaController vagaController;
        public GenEntradasSaidas()
        {
            InitializeComponent();
            entradasSaidasController = new EntradasSaidasController();
            vagaController = new VagaController();
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
            listaEntradasSaidas.Columns.Add("Pago", 80);
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
                item.SubItems.Add(entradaSaida.Pago ? "Sim" : "Não");

                listaEntradasSaidas.Items.Add(item);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listaEntradasSaidas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaEntradasSaidas.SelectedItems[0];
                int id = int.Parse(selectedItem.Text);
                entradasSaidasController.ExcluirRegistro(id);

                attBtn_Click(sender, e);

                MessageBox.Show("Registro excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }

        private void desativarBtn_Click(object sender, EventArgs e)
        {
            if (listaEntradasSaidas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaEntradasSaidas.SelectedItems[0];
                int idEntrada = int.Parse(selectedItem.Text);

                var entradaSaida = entradasSaidasController.GetEntradaSaidaById(idEntrada);

                if (entradaSaida != null)
                {
                    
                    if (entradaSaida.Vaga != null)
                    {
                        int vagaId = entradaSaida.Vaga.Id;

                        entradasSaidasController.RegistrarSaida(idEntrada);
                        vagaController.DesocuparVaga(vagaId);

                        MessageBox.Show("Saída registrada com sucesso!");
                        attBtn_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Esta entrada não tem uma vaga associada.");
                    }
                }
                else
                {
                    MessageBox.Show("Registro de entrada e saída não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para registrar a saída.");
            }
        }
    }
}
