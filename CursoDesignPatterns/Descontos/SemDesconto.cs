using CursoDesignPatterns.Descontos.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Desconto { get; set; }

        public double Desconta(Orcamento orcamento) => 0;

    }
}
