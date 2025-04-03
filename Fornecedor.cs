using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividaeUML
{
    public class Fornecedor
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }

        public Fornecedor(string nome, string cnpj)
        {
            this.RazaoSocial = nome;
            this.CNPJ = cnpj;
        }

    }
}
