using CursoDesignPatterns.Estados.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Estados
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.Valor -= (orcamento.Valor * 0.05);

        public void Aprova(Orcamento orcamento) => orcamento.EstadoAtual = new Aprovado();
        public void Reprova(Orcamento orcamento) => orcamento.EstadoAtual = new Reprovado();
        public void Finaliza(Orcamento orcamento)  => throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto ");

    }
}
