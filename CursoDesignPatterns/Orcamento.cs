using CursoDesignPatterns.Estados;
using CursoDesignPatterns.Estados.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public IEstadoDeUmOrcamento EstadoAtual { get; set; } = new EmAprovacao();
        public double Valor { get ;  set; }
        public IList<Item> Itens { get; private set; } = new List<Item>();

        public Orcamento(double valor) => Valor = valor;

        public void AplicaDescontoExtra() => EstadoAtual.AplicaDescontoExtra(this);
        public void AdcionaItem(Item item) => Itens.Add(item);

        public void Aprova () => EstadoAtual.Aprova(this);
        public void Reprova () => EstadoAtual.Reprova(this);
        public void Finaliza() => EstadoAtual.Finaliza(this);

    }
}
