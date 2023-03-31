using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSignIn
{
    public partial class Calculadora : Form
    {
        double v1;
        double v2;
        public Calculadora()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Calculadora_FormClosing);
        }

        private void suma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtval1.Text, out v1) || !double.TryParse(txtval2.Text, out v2))
            {
                MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtval1.Clear();
                txtval2.Clear();
            }
            else
                res.Text = Convert.ToString(v1 + v2);
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtval1.Text, out v1) || !double.TryParse(txtval2.Text, out v2))
            {
                MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtval1.Clear();
                txtval2.Clear();
            }
            else
                res.Text = Convert.ToString(v1 - v2);
        }

        private void mult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtval1.Text, out v1) || !double.TryParse(txtval2.Text, out v2))
            {
                MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtval1.Clear();
                txtval2.Clear();
            }
            else
                res.Text = Convert.ToString(v1 * v2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtval1.Text, out v1) || !double.TryParse(txtval2.Text, out v2))
            {
                MessageBox.Show("Ingrese números válidos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtval1.Clear();
                txtval2.Clear();
            }
            else
                res.Text = Convert.ToString(v1 / v2);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtval1.Clear();
            txtval2.Clear();
            res.Clear();
        }

        private void Calculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the app when clicking on the window's close button
            Application.Exit();
        }
    }
}
