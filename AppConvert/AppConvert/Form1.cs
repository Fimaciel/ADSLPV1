using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConvert.formularios;

namespace AppConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtHectoAlqu_Click(object sender, EventArgs e)
        {
            FormConverterHecparaAlq page = new FormConverterHecparaAlq();

            page.ShowDialog();
        }
    }
}
