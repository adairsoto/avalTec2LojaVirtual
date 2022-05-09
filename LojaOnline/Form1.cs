using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public static List<Produto> produtos = new List<Produto>();
        public static List<Produto> produtos = Produto.ProdutosRepository.InProdutos();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Telas.Cadastro cadastro = new Telas.Cadastro();
            cadastro.ShowDialog();
        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            Produto.Exibir(produtos, lstProdutos);
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Telas.Atualizar atualizar = new Telas.Atualizar();
            atualizar.ShowDialog();
        }
    }
}
