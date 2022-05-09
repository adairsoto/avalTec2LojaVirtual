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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto.Cadastrar(Form1.produtos, txtNomeProduto.Text, Convert.ToInt64(txtValorProduto.Text), Convert.ToInt32(txtQtdProduto.Text));
            var ans = MessageBox.Show("Deseja cadastrar outro produto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                txtNomeProduto.Clear();
                txtValorProduto.Clear();
                txtQtdProduto.Clear();
                return;
            }
            else
                Close();
            Form1 form = new Form1();
            Produto.Exibir(Form1.produtos, form.lstProdutos);
        }
    }
}
