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
    public partial class FormExemploAlerta : Form
    {
        public FormExemploAlerta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
            txtValor1.Select(); 
        }

     
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "" && txtValor2.Text == "")
            {
                MessageBox.Show("Os campos estão vazio, preenche-os porfavor!", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else if (txtValor1.Text == "" || txtValor2.Text == "") MessageBox.Show("Algum dos campos estão vazio, preenche-os porfavor!", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtValor2.Text == "0") {
                MessageBox.Show("Não é Possivel dividir por 0(zero)", "ADS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor2.Clear();
                txtValor2.Select();

            }


            double valor1 = Convert.ToDouble(txtValor1.Text);
            double valor2 = Convert.ToDouble(txtValor2.Text);
            double dividir = valor1 / valor2;
            txtResultado.Text = dividir.ToString();
        }
    }
}
