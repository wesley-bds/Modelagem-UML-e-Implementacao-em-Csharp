using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividaeUML
{
   public class NotaFiscal
    {
        public double Numero { get; set; }
        public Cliente Cliente { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<Produto> Produtos { get; set; }

        public NotaFiscal(Cliente cliente, Fornecedor fornecedor)
        {
            this.Cliente = cliente;
            this.Fornecedor = fornecedor;
            this.Produtos = new List<Produto>();
        }

        public void AdicionaProduto(Produto produto)
        {
            this.Produtos.Add(produto);
        }
    }
}
