using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dividendo = Convert.ToInt32(txtDividendo.Text);
            int Divisor = Convert.ToInt32(txtDivisor.Text);
            int Resto = Dividendo % Divisor;
            txtRestoDaDivisao.Text = Resto.ToString();
        }
    }
}
