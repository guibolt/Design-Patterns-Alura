using CursoDesignPatterns.Descontos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Calculadores
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoPorCincoItens();
            var d2 = new DescontoPorMaisDeQuihentosReais();
            var d3 = new DescontoPorVendaCasada();
            var d4 = new SemDesconto();
            d1.Desconto = d2;
            d2.Desconto = d3;
            d3.Desconto = d4;

            return d1.Desconta(orcamento);
        }
    }
}
