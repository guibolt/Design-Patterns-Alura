using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {
        public string RazaoSocal { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Obsrrvacoes { get; set; }

        public NotaFiscal(string razaoSocal, string cnpj, DateTime dataDeEmissao, double valorBruto, double impostos, IList<ItemDaNota> itens, string obsrrvacoes)
        {
            RazaoSocal = razaoSocal;
            Cnpj = cnpj;
            DataDeEmissao = dataDeEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Obsrrvacoes = obsrrvacoes;
        }
    }
}
