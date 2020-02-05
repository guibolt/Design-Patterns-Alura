using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class ICPP : TemplateDeImpostoCondificonal
    {
        public override bool DeveUsaMaximaTaxacao(Orcamento orcamento) => orcamento.Valor >= 500;
        public override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.07;
        public override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.05;
        
    }
}
