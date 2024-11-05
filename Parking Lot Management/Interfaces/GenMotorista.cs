using Parking_Lot_Management.Controller;
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
    public partial class GenMotorista : Form
    {
        private MotoristaController motoristaController;
        public GenMotorista()
        {
            InitializeComponent();
            motoristaController = new MotoristaController();
            CofigurarListView();
        }

        private void CofigurarListView() 
        {
            listaMotoristas.View = System.Windows.Forms.View.Details;
            listaMotoristas.FullRowSelect = true;
            listaMotoristas.GridLines = true;

            listaMotoristas.Columns.Add("ID", 50);
            listaMotoristas.Columns.Add("Nome", 150);
            listaMotoristas.Columns.Add("Email", 200);
            listaMotoristas.Columns.Add("Telefone", 100);
            listaMotoristas.Columns.Add("Ativo", 80);

        }
    }
}
