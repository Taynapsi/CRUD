using SistemaFinanceiro.Context;
using SistemaFinanceiro.Models;

namespace SistemaFinanceiro
{
    public static class Program
    {
        static void Main()
        {
            //GravarUsandoEntity();
            //RecuperarPessoa();
            //ExcluirPessoa();
            //RecuperarPessoa();
            //AtualizarPessoa();
        }

        private static void AtualizarPessoa()
        {         
            //atualiza o produto
            using(var contexto = new FinanceiroContext())
            {
                //seleciona o registro a ser alterado;
                PessoaModel primeira = contexto.Pessoa.First();
                //Seta novo valor para dado;
                primeira.Nome = "Tayna Souza Malaquias";
                contexto.Pessoa.Update(primeira);
                contexto.SaveChanges();
            }            
        }

        private static void ExcluirPessoa()
        {
            using (var contexto = new FinanceiroContext())
            {
                IList<PessoaModel> pessoas = contexto.Pessoa.ToList();
                foreach (var pessoa in pessoas)
                {
                    contexto.Pessoa.Remove(pessoa);
                }
                contexto.SaveChanges();
            }
        }

        private static void RecuperarPessoa()
        {
            using (var contexto = new FinanceiroContext())
            {
                IList<PessoaModel> pessoas = contexto.Pessoa.ToList();                
                foreach (var item in pessoas)
                {
                    Console.WriteLine(item.Nome);
                    Console.WriteLine(item.Cpf_Cnpj);
                }                
            }
        }

        private static void GravarUsandoEntity()
        {
            PessoaModel p = new PessoaModel();
            p.Nome = "Taynã Souza Malaquias";
            p.Cpf_Cnpj = "75755726191";
            using ( var contexto = new FinanceiroContext())
            {
                contexto.Pessoa.Add(p);
                contexto.SaveChanges();
            }
        }
    }
}



