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
    public partial class Atualizar : Form
    {
        public Atualizar()
        {
            InitializeComponent();
        }

        private void btnAtProduto_Click(object sender, EventArgs e)
        {
            int ind = lstAtProdutos.SelectedIndex;
            try
            {
                if (Form1.produtos[ind].QtdEstoque != Convert.ToInt32(txtAtQtd.Text) || Form1.produtos[ind].ValorProduto != Convert.ToInt64(txtAtValor.Text))
                {
                    if (Form1.produtos[ind].QtdEstoque != Convert.ToInt32(txtAtQtd.Text))
                        Form1.produtos[ind].QtdEstoque = Convert.ToInt32(txtAtQtd.Text);

                    if (Form1.produtos[ind].ValorProduto != Convert.ToInt64(txtAtValor.Text))
                        Form1.produtos[ind].ValorProduto = Convert.ToInt64(txtAtValor.Text);
                    Produto.Exibir(Form1.produtos, lstAtProdutos);
                }
                else
                {
                    MessageBox.Show("Para que o produto seja atualizado a quantidade ou o valor deve ser diferente do atual", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAtQtd.Clear();
                    txtAtValor.Clear();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Formato Inválido", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lstAtProdutos.SelectedIndex = -1;
                txtAtQtd.Clear();
                txtAtValor.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecione o Produto que deseja atualizar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Atualizar_Load(object sender, EventArgs e)
        {
            Produto.Exibir(Form1.produtos, lstAtProdutos);
        }
        private void btnRemProduto_Click(object sender, EventArgs e)
        {
            var asw = MessageBox.Show("Deseja realmente remover este produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (asw == DialogResult.Yes)
            {
                int ind = lstAtProdutos.SelectedIndex;

                List<Produto> produto = new List<Produto>();

                produto.Add((Produto)lstAtProdutos.Items[ind]);
               
                Form1.produtos.Remove(produto[0]);
                
                Produto.Exibir(Form1.produtos, lstAtProdutos);
            }
            else
                return;
        }
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            Produto.BuscarProduto(Form1.produtos, lstAtProdutos, txtBuscarProd.Text);
            txtBuscarProd.Clear();
        }
    }
}
