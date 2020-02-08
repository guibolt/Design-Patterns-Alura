using CursoDesignPatterns.Calculadores;
using CursoDesignPatterns.Impostos;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder
            //DeNotaFiscalBuilder criador = new DeNotaFiscalBuilder();

            //criador.ParaEmpresa("Caelum Ensino e Inovacao");
            //criador.ComCnpj("23.456.789/001-12");
            //criador.AdcionaESomaItens(new ItemDaNota("Chuveiro", 150));
            //criador.AdcionaESomaItens(new ItemDaNota("Copo", 15));
            //criador.NaDataAtual();
            //criador.ComObersacoes("Algo bem legal que estou escrevendo");

            //criador.AddAcao(new EnviadorDeEmail());
            //criador.AddAcao(new SalvaNoBanco());
            //criador.AddAcao(new EnviaSMS());
            //NotaFiscal nf = criador.Costroi();

            //Console.WriteLine($"Valor da nota {nf.ValorBruto}");
            //Console.WriteLine($"Valor dos impostos da nota {nf.Impostos}");

            //Console.ReadLine();
            #endregion 

            #region State
            //State

            //var orcamento = new Orcamento(500);
            //Console.WriteLine(orcamento.Valor) ;
            //orcamento.AplicaDescontoExtra();
            //Console.WriteLine(orcamento.Valor);
            //orcamento.Aprova();
            //orcamento.AplicaDescontoExtra();
            //Console.WriteLine(orcamento.Valor);
            //orcamento.Finaliza();
            //Console.ReadLine();
            #endregion

            #region Chain of Responsability
            //Chain of Responsability
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500);
            //orcamento.AdcionaItem(new Item("Lápis", 550));
            //orcamento.AdcionaItem(new Item("Caneta", 550));

            //var desconto = calculador.Calcula(orcamento);

            //Console.WriteLine(desconto);

            //Console.ReadLine();
            #endregion 
        }
    }
}
