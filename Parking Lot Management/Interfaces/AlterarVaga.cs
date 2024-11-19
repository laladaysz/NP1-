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
        public AlterarVaga(Vaga vaga)
        {
            InitializeComponent();
            vagaController = new VagaController();

            numTxt.Text = vaga.Numero;
            tipoTxt.Text = vaga.Tipo;
            locTxt.Text = vaga.Localizacao;
        }
    }
}
