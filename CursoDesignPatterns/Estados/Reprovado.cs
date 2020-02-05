using CursoDesignPatterns.Estados.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Estados
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new Exception("Orcamento reprovados nao recebem desconto extra");
        public void Aprova(Orcamento orcamento) => throw new Exception("Orcamento ja esta em estado de reprovacao");

        public void Reprova(Orcamento orcamento) => throw new Exception("Orcamento ja esta reprovado, nao pode ser repovrado agora");

        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();
    }
}
