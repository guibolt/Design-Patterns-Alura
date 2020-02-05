using CursoDesignPatterns.Descontos.Interface;

namespace CursoDesignPatterns.Descontos
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Desconto { get; set; }

        public double Desconta(Orcamento orcamento) => orcamento.Itens.Count > 5 ? orcamento.Valor * 0.1 : Desconto.Desconta(orcamento);
    }
}
