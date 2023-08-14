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
    public partial class FormExemploComboBox : Form
    {
        public FormExemploComboBox()
        {
            InitializeComponent();
            txtPercDesconto.Visible = false;
            lbPercDesconto.Visible = false;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);
            double valorcomDesconto = 0.00;
            switch(tipoCliente)
            {
                case 0:
                {
                        valorcomDesconto = valorCompra - valorCompra * 0.25;
                        txtResultado.Text = valorcomDesconto.ToString("C2");
                        break;
                }
                case 1:
                    {
                        valorcomDesconto = valorCompra - valorCompra * 0.20;
                        txtResultado.Text = valorcomDesconto.ToString("C2");
                        break;
                    }
                case 2:
                    {
                        valorcomDesconto = valorCompra - valorCompra * 0.15;
                        txtResultado.Text = valorcomDesconto.ToString("C2");
                        break;
                    }
                case 3:
                    {
                        valorcomDesconto = valorCompra - valorCompra * 0.10;
                        txtResultado.Text = valorcomDesconto.ToString("C2");
                        break;
                    }
                case 4:
                    {
                        double desconto = Convert.ToDouble(txtPercDesconto.Text);
                        desconto /= 100;
                        valorcomDesconto = valorCompra - valorCompra * desconto;
                        txtResultado.Text = valorcomDesconto.ToString("C2");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Selecione um Cliente!", "ADS/Jipa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }  
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;

            if (tipoCliente == 4) {
                txtPercDesconto.Visible = true;
                lbPercDesconto.Visible = true;
            }
            else
            {
                txtPercDesconto.Visible = false;
                lbPercDesconto.Visible = false;
            }

        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            cbTipoCliente.SelectedIndex = -1;
            txtValorCompra.Clear();
            txtPercDesconto.Clear();
            txtResultado.Clear();
            cbTipoCliente.Select();
        }
    }
}
