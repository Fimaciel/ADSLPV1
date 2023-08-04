using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConvert.formularios
{
    public partial class FormConverterHecparaAlq : Form
    {
        public FormConverterHecparaAlq()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtHectoAlq_TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtAlqresult_TextChanged(object sender, EventArgs e)
        {

        }
        private void BtnConverter_Click(object sender, EventArgs e)
        {
            double hec = Convert.ToDouble(TxtHectoAlq.Text);
            double alq = hec / 2.42;
            TxtAlqresult.Text = alq.ToString("F2");   
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtAlqresult.Clear();
            TxtHectoAlq.Clear();
            TxtHectoAlq.Select();

        }


    }
}
