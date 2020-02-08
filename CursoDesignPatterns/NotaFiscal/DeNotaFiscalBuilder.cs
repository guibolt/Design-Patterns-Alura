using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace CursoDesignPatterns
{
    public class DeNotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<IAcaoAposGerarNota> acaoAposGerarNotas = new List<IAcaoAposGerarNota>();

        public DeNotaFiscalBuilder()
        {
        }

        public void ParaEmpresa(string v) => RazaoSocial = v;

        public void ComObersacoes(string observacoes) => Observacoes = observacoes;

        public NotaFiscal Costroi()
        {
            foreach (var itemA in acaoAposGerarNotas)
                itemA.Executa();

            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }


        public void AddAcao(IAcaoAposGerarNota novaAcao) => acaoAposGerarNotas.Add(novaAcao);



        public void NaDataAtual() => Data = DateTime.Now;

        public void ComCnpj(string v) => Cnpj = v;

        public void AdcionaESomaItens(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
        }
        
    }
}