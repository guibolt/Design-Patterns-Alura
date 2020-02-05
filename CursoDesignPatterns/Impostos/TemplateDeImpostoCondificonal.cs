using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public abstract class TemplateDeImpostoCondificonal : Imposto
    {

        //Template method!
        public override double Calcula(Orcamento orcamento) => DeveUsaMaximaTaxacao(orcamento) ? MaximaTaxacao(orcamento) : MinimaTaxacao(orcamento);
    
        public abstract bool DeveUsaMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
