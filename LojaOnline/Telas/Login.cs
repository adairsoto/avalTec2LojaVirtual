using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaOnline.Telas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userAdmin = "admin";
            var pwAdmin = "admin";
            var userClient = "cliente";
            var pwClient = "cliente";

            if (txtLogin.Text == userAdmin && txtPassword.Text == pwAdmin)
            {
                Form1 form = new Form1();
                form.ShowDialog();
                txtLogin.Clear();
                txtPassword.Clear();
            }
            else if (txtLogin.Text == userClient && txtPassword.Text == pwClient)
            {
                Cliente cliente = new Cliente();
                cliente.ShowDialog();
                txtLogin.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Login ou Senha Incorreta","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
                txtLogin.Clear();
                txtPassword.Clear();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
