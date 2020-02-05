using CursoDesignPatterns.Estados.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Estados
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => orcamento.Valor -= orcamento.Valor * 0.02;

        public void Aprova(Orcamento orcamento) => throw new Exception("Orcamento ja esta em estado de aprovacao");
       
        public void Reprova(Orcamento orcamento) =>   throw new Exception("Orcamento ja esta aprovado, nao pode ser repovrado agora");
        
        public void Finaliza(Orcamento orcamento) =>  orcamento.EstadoAtual = new Finalizado();
       
    }
}
