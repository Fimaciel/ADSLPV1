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
    public partial class FormExemploGrid : Form
    {
        public FormExemploGrid()
        {
            InitializeComponent();
        }

        private void FormExemploGrid_Load(object sender, EventArgs e)
        {

        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            dgvTabela.Rows.Add(txtDescricao.Text, Convert.ToDouble(txtValorUnit.Text), Convert.ToDouble(txtQuant.Text),
                Convert.ToDouble(txtTotal.Text));

            totalizar();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            int linha = dgvTabela.CurrentRow.Index;
            int qntlinhas = dgvTabela.RowCount;
            if(qntlinhas > 1) {
                DialogResult resp = MessageBox.Show("Deseja mesmo Deletar?", "ADS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    dgvTabela.Rows.RemoveAt(linha);
                    totalizar();
                }
            }
        }

        private void txtDescricao_keyup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtValorUnit.Select();
            }
        }

        private void txtValorUnit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuant.Select();
            }
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            double quanti = Convert.ToDouble(txtQuant.Text);
            double valorUnit = Convert.ToDouble(txtValorUnit.Text);
            double total = quanti * valorUnit;

            txtTotal.Text = total.ToString();
            txtTotal.Text = total.ToString();
            txtTotal.ReadOnly = true;

        }

        private void totalizar()
        {

            double total = 0;
            for (int i = 0; i< dgvTabela.RowCount; i++)
            {
                total = Convert.ToDouble(dgvTabela[3, i].Value) + total;

            }
            txtTotalGeral.Text = total.ToString("c2");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtQuant.Clear();
            txtTotal.Clear();
            txtTotalGeral.Clear();
            txtValorUnit.Clear();
            txtDescricao.Select();
        }
    }
}
