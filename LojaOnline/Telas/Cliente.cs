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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        public static List<Compra> compra = new List<Compra>();
        private void btnExibirProd_Click(object sender, EventArgs e)
        {
            Produto.Exibir(Form1.produtos, lstProdCliente);
        }

        private void btnAddCarr_Click(object sender, EventArgs e)
        {
            int ind = lstProdCliente.SelectedIndex;
            
            compra.Add(new Compra(compra.Count + 1, Form1.produtos[ind].NomeProduto, Form1.produtos[ind].ValorProduto, Convert.ToInt32(txtQtdCarr.Text)));
            Form1.produtos[ind].QtdEstoque -= Convert.ToInt32(txtQtdCarr.Text);
            Produto.Exibir(Form1.produtos, lstProdCliente);
        }

        private void btnIrCarr_Click(object sender, EventArgs e)
        {
            Telas.Carrinho carrinho = new Telas.Carrinho();
            carrinho.ShowDialog();
        }
    }
}
