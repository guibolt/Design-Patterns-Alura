using CursoDesignPatterns.Descontos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Desconto { get ; set ; }

        public double Desconta(Orcamento orcamento) => orcamento.Itens.Any(i => i.Nome == "Lápis") && orcamento.Itens.Any(p => p.Nome == "Caneta") ?
            orcamento.Valor * 0.5 : Desconto.Desconta(orcamento);
  
    }
}
