using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaOnline
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public int QtdEstoque { get; set; }
        public Produto(int id, string nomeProduto, double valorProduto, int qtdEstoque)
        {
            Id = id;
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            QtdEstoque = qtdEstoque;
        }
        public override string ToString()
        {
            return $"{Id} - Produto: {NomeProduto} - Valor: R$ {ValorProduto:F2} - Qtd em Estoque: {QtdEstoque}";
        }
        public static List<Produto> Cadastrar(List<Produto> produtos, string nome, double valor, int qtd)
        {
            produtos.Add(new Produto(produtos.Count +1, nome, valor, qtd));
            return produtos;
        }
        public static void Exibir(List<Produto> produtos, ListBox list)
        {
            list.Items.Clear();
            foreach (var p in produtos)
            {
                list.Items.Add(p);
            }
        }
        public static void BuscarProduto(List<Produto> produtos, ListBox list, string nome)
        {
            List<Produto> buscaProdutos = new List<Produto>();

            buscaProdutos = produtos.FindAll(x => x.NomeProduto == nome);
            foreach (var produto in buscaProdutos)
            {
                list.Items.Add(produto);
            }
            Produto.Exibir(buscaProdutos, list);
        }

        public class ProdutosRepository
        {
            public static List<Produto> InProdutos()
            {
                List<Produto> produtos = new List<Produto>();
                produtos.Add(new Produto(1, "Mouse", 250, 200));
                produtos.Add(new Produto(2, "Teclado", 350, 300));
                produtos.Add(new Produto(3, "Monitor", 1500, 100));

                return produtos;
            }

            
        }
    }
}
