using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto) => OutroImposto = outroImposto;
        public Imposto() => OutroImposto = null;

        protected double CalculoDoOutroImposto(Orcamento orcamento) => OutroImposto == null ? 0 : OutroImposto.Calcula(orcamento);

        public abstract double Calcula(Orcamento orcamento);
    }
}
