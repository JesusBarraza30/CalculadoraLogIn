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
    public partial class Form1 : Form
    {
        private List<User> listausers = new List<User>();
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listausers.Add(new User("ADMIN", "ADMIN"));
            listausers.Add(new User("JBC", "1234"));
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            User usuario = listausers.FirstOrDefault(x => x.pUserName.Equals(txtUser.Text) && x.pPassWord.Equals(txtPass.Text));
            if (usuario != null) {
                Calculadora ventanaCalculadora = new Calculadora();
                this.Hide();
                ventanaCalculadora.Show();
            }
            if (usuario == null) {
                MessageBox.Show("El usuario y/o contraseña ingresados son incorrectos", "Error",  MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the app when clicking on the window's close button
            Application.Exit();
        }
    }
}
