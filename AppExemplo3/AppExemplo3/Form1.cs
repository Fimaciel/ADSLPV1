using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppExemplo3.Formularios; 

namespace AppExemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExemploListBox_Click(object sender, EventArgs e)
        {
            FormExemploListBox form = new FormExemploListBox();
            form.ShowDialog();
        }

        private void btExemploGrid_Click(object sender, EventArgs e)
        {
            FormExemploGrid form = new FormExemploGrid();
            form.ShowDialog();
        }

        private void btExemploCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarVeiculos form = new FormCadastrarVeiculos();
            form.ShowDialog();
        }

        private void btExemploListarList_Click(object sender, EventArgs e)
        {
            FormExemploListarComListBox form = new FormExemploListarComListBox();
            form.ShowDialog();
        }

        private void btExemploListarGrid_Click(object sender, EventArgs e)
        {
            FormExemploListarComGrid form = new FormExemploListarComGrid();
            form.ShowDialog();
        }

        private void btExemploCadastrarTabela_Click(object sender, EventArgs e)
        {
            FormCadastrarProdutos form = new FormCadastrarProdutos();
            form.ShowDialog();
        }
    }
}
