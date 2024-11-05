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
    }
}
