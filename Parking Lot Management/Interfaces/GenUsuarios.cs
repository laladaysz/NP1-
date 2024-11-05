using Parking_Lot_Management.Controller;
using Parking_Lot_Management.Dao;
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

namespace Parking_Lot_Management.View
{
    public partial class GenUsuarios : Form
    {
        private UsuarioController usuarioController;
        public GenUsuarios()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
            ConfigurarListView();
        }

        private void ConfigurarListView()
        {
            listaUsuarios.View = System.Windows.Forms.View.Details;
            listaUsuarios.FullRowSelect = true;
            listaUsuarios.GridLines = true;

            listaUsuarios.Columns.Add("ID", 50);
            listaUsuarios.Columns.Add("Nome", 150);
            listaUsuarios.Columns.Add("Email", 200);
            listaUsuarios.Columns.Add("Role", 100);
            listaUsuarios.Columns.Add("Ativado", 80);
        }

        private void button1_Click(object sender, EventArgs e) // att button
        {
            List<Usuario> usuarios = usuarioController.GetAllUsuarios();
            listaUsuarios.Items.Clear();

            foreach (var usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Nome);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.Role);
                item.SubItems.Add(usuario.Ativado ? "Sim" : "Não");

                listaUsuarios.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e) // del button

        {
            if (listaUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaUsuarios.SelectedItems[0];
                int usuarioId = int.Parse(selectedItem.Text);
                usuarioController.ExcluirUsuario(usuarioId);

                button1_Click(sender, e);

                MessageBox.Show("Usuário excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um usuário para excluir.");
            }
        }

        private void listaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // pesquisar btn
        {
            if (int.TryParse(idTxtBox.Text, out int usuarioId))
            {
                Usuario usuario = usuarioController.BuscarUsuarioPorId(usuarioId);
                listaUsuarios.Items.Clear();

                if (usuario != null)
                {
                    ListViewItem item = new ListViewItem(usuario.Id.ToString());
                    item.SubItems.Add(usuario.Nome);
                    item.SubItems.Add(usuario.Email);
                    item.SubItems.Add(usuario.Role);
                    item.SubItems.Add(usuario.Ativado ? "Sim" : "Não");

                    listaUsuarios.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID inválido. Por favor, insira um número válido.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //voltar btn
        {
            this.Close();
            HomeAdmin homeAdmin = new HomeAdmin();
            homeAdmin.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void admBtn_Click(object sender, EventArgs e) //tornar adm
        {
            if (listaUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaUsuarios.SelectedItems[0];
                int usuarioId = int.Parse(selectedItem.Text);
                usuarioController.TornarAdmin(usuarioId);

                button1_Click(sender, e);

                MessageBox.Show("Usuário alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um usuário para tornar administrador.");
            }
        }

        private void desativarBtn_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaUsuarios.SelectedItems[0];
                int usuarioId = int.Parse(selectedItem.Text);
                usuarioController.Desativar(usuarioId);

                button1_Click(sender, e);

                MessageBox.Show("Usuário desativado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um usuário para desativar.");
            }
        }
    }
}
