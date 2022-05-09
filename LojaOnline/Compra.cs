using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    public class Compra
    {
         public int Id { get; set; }
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public int Qtd { get; set; }
        public Compra(int id, string nomeProduto, double valorProduto, int qtd)
        {
            Id = id;
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            Qtd = qtd;
        }
        public override string ToString()
        {
            return $"Produto: {NomeProduto} - Quantidade: {Qtd} - Valor Total: R$ {ValorProduto * Qtd:F2}";
        }
    }
}
