using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.formularios
{
    public partial class FormExemploRotulos : Form
    {
        public FormExemploRotulos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            txtPercentual.Clear();
            txtSalarioAtual.Clear();
            txtSalarioAtual.Select();
            lbResultado.Text = "Salario Reajustado";
            lbResultado.ForeColor = Color.Black;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double salarioAtual = 0;
            double percentual = 0;
            double salarioReajustado = 0;

            salarioAtual = Convert.ToDouble(txtSalarioAtual.Text);
            percentual = Convert.ToDouble(txtPercentual.Text);
            percentual = percentual / 100;
            salarioReajustado = salarioAtual + salarioAtual * percentual;
            lbResultado.Text = "O Salario atualizado: " + salarioReajustado.ToString("C2");
            lbResultado.ForeColor = Color.Blue;

        }

        private void txtSalarioAtual_KeyDown(object sender, KeyEventArgs e)
        {
            verificardonw(e);
        }

        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {
            verificarUp(e);
        }

        void verificardonw(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSalarioAtual.Text == "")
                {
                    MessageBox.Show("O campo está vazio!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalarioAtual.Select();
                }
                else txtPercentual.Select();
            }

        }
        void verificarUp(KeyEventArgs e)
        {
            bool verificarNumero = false;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;
            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;

                if (e.KeyCode == Keys.Enter) verificarNumero = true;

                if (e.KeyCode == Keys.Back) verificarNumero = true;

                int qtdVirgula = txtSalarioAtual.Text.Count(v => v == ',');
                if (qtdVirgula > 1) verificarNumero = false;


            }
            if (verificarNumero == false)
            {
                MessageBox.Show("Somente Números:", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioAtual.Text = txtSalarioAtual.Text.Remove((txtSalarioAtual.Text.Length) - 1);
             
            }
        }
        private void TxtPercentual_keydown(object sender, KeyEventArgs e)
        {
            verificardonw(e);
        }

        private void TxtPercentual_Keyup(object sender, KeyEventArgs e)
        {
            verificarUp(e);

        }
        private void lbResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtPercentual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSalarioAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

  
    }
}
