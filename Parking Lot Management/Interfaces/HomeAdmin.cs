﻿using Parking_Lot_Management.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Lot_Management.View
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void GenUsersBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            View.GenUsuarios genUsuarios = new View.GenUsuarios();
            genUsuarios.Show();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroMotoristas cadastroMotoristas = new CadastroMotoristas();
            cadastroMotoristas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GenMotorista genMotorista = new GenMotorista();
            genMotorista.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroVeiculo cadastroveiculos = new CadastroVeiculo();
            cadastroveiculos.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            GenVeiculos genVeiculos = new GenVeiculos();
            genVeiculos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroVaga cadastroVaga = new CadastroVaga();
            cadastroVaga.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            GenVagas genVagas = new GenVagas();
            genVagas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroEntrada cadastroentrada = new CadastroEntrada();
            cadastroentrada.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            GenEntradasSaidas genEntradas = new GenEntradasSaidas();
            genEntradas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            BI bI = new BI();
            bI.Show();
        }
    }
}
