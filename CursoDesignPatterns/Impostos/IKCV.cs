using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Impostos
{
    public class IKCV : TemplateDeImpostoCondificonal
    {
        public override double Calcula(Orcamento orcamento)
        {
            return 0;
        }
        public override bool DeveUsaMaximaTaxacao(Orcamento orcamento) => orcamento.Valor > 500 && TemItemMaiorQueCem(orcamento);

        public override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.10;
        public override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.06;
       
        private bool TemItemMaiorQueCem(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
                if (item.Valor > 100)
                    return true;

            return false;
        }
    }
}
