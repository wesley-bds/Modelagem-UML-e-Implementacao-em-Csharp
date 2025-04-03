using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividaeUML
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Produto(string descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}
