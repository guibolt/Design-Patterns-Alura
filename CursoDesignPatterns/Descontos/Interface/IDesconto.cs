using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Descontos.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        public IDesconto Desconto { get; set; }
    }
}
