using SistemaFinanceiro.Context;
using SistemaFinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro
{
    public class Crud : IDisposable
    {
        private FinanceiroContext contexto;

        public void Dispose()
        {
            contexto.Dispose();
        }
        public Crud()
        {
            this.contexto = new FinanceiroContext();
        }
        public void Adicionar(PessoaModel p)
        {
            contexto.Pessoa.Add(p);
            contexto.SaveChanges();
        }

        public void Atualizar(PessoaModel p)
        {
            contexto.Pessoa.Update(p);
            contexto.SaveChanges();
        }
        public IList<PessoaModel> Ler()
        {
            return contexto.Pessoa.ToList();
        }
        public void Remover(PessoaModel p)
        {
            contexto.Pessoa.Remove(p);
            contexto.SaveChanges();
        }

    }
}
