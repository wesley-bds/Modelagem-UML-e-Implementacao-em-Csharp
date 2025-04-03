using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividaeUML
{
    public class Cliente : Pessoa
    {
        public string CPF { get; set; }
        public string RG { get; set; }

        public Cliente(string cpf, string nome)
        {
            this.CPF = cpf;
            this.Nome = nome;

        }
    }
}
