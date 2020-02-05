using CursoDesignPatterns.Descontos.Interface;

namespace CursoDesignPatterns.Descontos
{
    public class DescontoPorMaisDeQuihentosReais : IDesconto
    {
        public IDesconto Desconto { get; set; }

        public double Desconta(Orcamento orcamento) => orcamento.Valor < 500 ? orcamento.Valor * 0.07 : Desconto.Desconta(orcamento);
    }
}
