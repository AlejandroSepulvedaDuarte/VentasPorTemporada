using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemporadaPorVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbtemporada1_Click(object sender, EventArgs e)
        {
            Temp1 temp1 = new Temp1();
            temp1.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbtemporada2_Click(object sender, EventArgs e)
        {
            Temp2 temp2 = new Temp2();
            temp2.Show();
            this.Hide();
        }

        private void pbtemporada3_Click(object sender, EventArgs e)
        {
            Temp3 temp3 = new Temp3();
            temp3.Show();
            this.Hide();
        }
    }
}
