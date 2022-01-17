using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Models
{
    //Nome da tabela no banco.
    [Table("PESSOA")]
    //Nome da classe que representa a tabela, no codigo.
    public class PessoaModel
    {
        //Nome da coluna na tabela no banco.
        [Column("ID")]
        //Nome da propriedade que representa a coluna, no codigo.
        public int Id { get; set; }

        [Column("NOME_RZ_SOCIAL")]
        public string Nome { get; set; }

        [Column("CPF_CNPJ")]
        public string Cpf_Cnpj { get; set; }

    }
}
