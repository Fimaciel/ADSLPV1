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
    public partial class FormAlertas : Form
    {
        public FormAlertas()
        {
            InitializeComponent();
        }

        private void FormAlertas_Load(object sender, EventArgs e)
        {

        }

        private void BtnInformacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Mensagem", "Texto do Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto da Mensagem", "Texto do Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botafogo de Futebol e Regatas?","Bo Ta Fo Go", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void BtnExemplo_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Gosta de futebol?", "ADS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MessageBox.Show("Resposta: "+ resposta.ToString(), "ADS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resposta = MessageBox.Show("Deseja fechar o Programa?", "ADS", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
