using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOnline
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public FormaPagamento(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

    }

    public class MetPagamento
    {
        public static ArrayList InMetPagamento()
        {
            ArrayList formaPag = new ArrayList
        {
            new FormaPagamento(1, "Selecione:"),
            new FormaPagamento(2, "Dinheiro"),
            new FormaPagamento(3, "Cartão"),
            new FormaPagamento(4, "Boleto"),
            new FormaPagamento(5, "Pix")
        };
            return formaPag;
        }

    }

    

}
