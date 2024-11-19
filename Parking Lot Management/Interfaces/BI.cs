using Parking_Lot_Management.Controller;
using Parking_Lot_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Parking_Lot_Management.Interfaces
{
    public partial class BI : Form
    {
        private EntradasSaidasController entradasSaidasController;

        public BI()
        {
            InitializeComponent();
            InitializeList();
            entradasSaidasController = new EntradasSaidasController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void InitializeList()
        {
            
            this.relatorios.View = System.Windows.Forms.View.Details;
            this.relatorios.FullRowSelect = true;
            this.relatorios.GridLines = true;

            
            this.relatorios.Columns.Add("Descrição", 150);
            this.relatorios.Columns.Add("Total Entradas", 120);
            this.relatorios.Columns.Add("Total Saídas", 120);
            this.relatorios.Columns.Add("Total Pagos", 120);
            this.relatorios.Columns.Add("Total Não Pagos", 120);

            
            this.relatorios.Size = new System.Drawing.Size(700, 300); 
            this.relatorios.Location = new System.Drawing.Point(50, 50); 


            this.Controls.Add(this.relatorios);
        }

        

        private void CarregarRelatorio()
        {
            
            relatorios.Items.Clear();

           
            List<EntradasSaidas> entradasSaidas = entradasSaidasController.GetEntradasSaidas();

           
            int totalEntradas = entradasSaidas.Count(es => es.Saida == null);  
            int totalSaidas = entradasSaidas.Count(es => es.Saida != null);    
            int totalPagos = entradasSaidas.Count(es => es.Pago);              
            int totalNaoPagos = entradasSaidas.Count(es => !es.Pago);          

            
            ListViewItem item = new ListViewItem("Resumo");
            item.SubItems.Add(totalEntradas.ToString());
            item.SubItems.Add(totalSaidas.ToString());
            item.SubItems.Add(totalPagos.ToString());
            item.SubItems.Add(totalNaoPagos.ToString());

            
            relatorios.Items.Add(item);
        }
    }
}
