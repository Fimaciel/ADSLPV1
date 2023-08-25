using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo3.Formularios
{
    public partial class FormExemploListBox : Form
    {
        public FormExemploListBox()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtAno.Clear(); txtModelo.Clear();
            txtPlaca.Clear(); txtModelo.Focus();

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            string cadastro = txtModelo.Text + " | " + txtPlaca.Text + " | " + txtAno.Text;

            listVeiculos.Items.Add(cadastro);

            MessageBox.Show("Salvo com sucesso", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btCancelar_Click(sender, e);
            
        }

        private void listVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
