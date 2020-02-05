using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCauculo(Orcamento orcamento, Imposto imposto)
        {
            var icms = imposto.Calcula(orcamento);
            Console.WriteLine(icms);
        }
    }
}
