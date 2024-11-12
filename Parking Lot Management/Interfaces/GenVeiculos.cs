﻿using Parking_Lot_Management.Controller;
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
    public partial class GenVeiculos : Form
    {
        VeiculoController veiculoControl;
        public GenVeiculos()
        {
            InitializeComponent();
            veiculoControl = new VeiculoController();
            CofigurarListView();
        }

        private void CofigurarListView()
        {
            listaVeiculos.View = System.Windows.Forms.View.Details;
            listaVeiculos.FullRowSelect = true;
            listaVeiculos.GridLines = true;

            listaVeiculos.Columns.Add("ID", 50);
            listaVeiculos.Columns.Add("Placa", 150);
            listaVeiculos.Columns.Add("Modelo", 200);
            listaVeiculos.Columns.Add("Cor", 100);
            listaVeiculos.Columns.Add("Motorista", 80);

        }
        private void attBtn_Click(object sender, EventArgs e)
        {
            listaVeiculos.Items.Clear();

            var veiculosComMotorista = veiculoControl.GetVeiculosComMotorista();

            foreach (var (veiculo, nomeMotorista) in veiculosComMotorista)
            {
                ListViewItem item = new ListViewItem(veiculo.Id.ToString());
                item.SubItems.Add(veiculo.Placa);
                item.SubItems.Add(veiculo.Modelo);
                item.SubItems.Add(veiculo.Cor);
                item.SubItems.Add(nomeMotorista);

                listaVeiculos.Items.Add(item);
            }

        }
    }
}
