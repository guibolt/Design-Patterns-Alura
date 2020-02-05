using CursoDesignPatterns.Calculadores;
using CursoDesignPatterns.Impostos;
using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var orcamento = new Orcamento(500);
            Console.WriteLine(orcamento.Valor) ;
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);
            orcamento.Aprova();
            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);
            orcamento.Finaliza();
            Console.ReadLine();
          





            //Chain of Responsability
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500);
            //orcamento.AdcionaItem(new Item("Lápis", 550));
            //orcamento.AdcionaItem(new Item("Caneta", 550));

            //var desconto = calculador.Calcula(orcamento);

            //Console.WriteLine(desconto);

            //Console.ReadLine();
        }
    }
}
