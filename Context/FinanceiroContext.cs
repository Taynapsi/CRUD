using SistemaFinanceiro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Context
{
    //Classe Herda de DbContext;
    public class FinanceiroContext : DbContext
    {
        //Qual a classe que o contexto deve persistir;
        public DbSet<PessoaModel> Pessoa { get; set; }

        //Reescrevo o metodo OnConfiguring, passando a string de conexão com o banco;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=NTB-C56D2L3;Initial Catalog=CADASTRO_DE_PESSOAS;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
