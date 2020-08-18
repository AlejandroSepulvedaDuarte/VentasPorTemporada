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
    public partial class Temp1 : Form
    {
        public Temp1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double subtotal, des, total;
            subtotal = double.Parse(txtvalor.Text);
            if (subtotal <= 100000)
            {
                des = subtotal * 0;

            }
            else if (subtotal>=100001 && subtotal<=300000)
            {
                des = subtotal * 0.1;
            }
            else
            {
                des = subtotal * 0.15;
            }
            total = subtotal - des;
            lblsubtotal.Text = Convert.ToString(String.Format("{0:n}", subtotal));
            lbldescuento.Text = Convert.ToString(String.Format("{0:n}", des));
            lbltotal.Text= Convert.ToString(String.Format("{0:n}", total));
            gbdescripcion.Visible = true;
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1 ();
            form1.Show();
            this.Dispose();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtvalor.Text = String.Empty;
            gbdescripcion.Visible = false;
            txtvalor.Focus();
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 4))
            {
                MessageBox.Show("Solo se aceptan números;Estos deben ser positivos", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
