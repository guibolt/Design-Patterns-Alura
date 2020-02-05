using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICMS: Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }
        public ICMS(): base()
        {

        }
        public override double Calcula(Orcamento orcamento) => orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
    }
}
