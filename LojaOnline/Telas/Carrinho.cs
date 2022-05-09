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
    public partial class Carrinho : Form
    {
        public Carrinho()
        {
            InitializeComponent();
        }

        private void Carrinho_Load(object sender, EventArgs e)
        {
            foreach (var item in Cliente.compra)
            {
                lstCarr.Items.Add(item);
            }
            comboBox1.DataSource = MetPagamento.InMetPagamento();
            comboBox1.ValueMember = "Descricao"; 
        }
        private void btnFinCompra_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
            {
                lblProd1.Text = $"{Cliente.compra[0].NomeProduto} - Quantidade: {Cliente.compra[0].Qtd}";
                lblProd2.Text = $"{Cliente.compra[1].NomeProduto} - Quantidade: {Cliente.compra[1].Qtd}";

                lblFormaPag.Text = $"Forma de Pagamento: {comboBox1.Text}";
                double calc = 0;
                for (int i = 0; i < Cliente.compra.Count; i++)
                {
                    calc += (Cliente.compra[i].ValorProduto * Cliente.compra[i].Qtd);
                }
                lblValorTotal.Text = $"Valor Total da Compra: R$ {calc:F2}";
            }
            else
            {
                MessageBox.Show("Infome o Método de Pagamento", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }
    }
}
