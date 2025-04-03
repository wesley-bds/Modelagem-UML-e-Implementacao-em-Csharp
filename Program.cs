using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividaeUML

{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("157.010.151-69", "Wesley Silva");
            Fornecedor fornecedor = new Fornecedor("Kabum", "12.345.678/0001-99");
            Produto produto = new Produto("Notebook", 7500.00);

            NotaFiscal nota = new NotaFiscal(cliente, fornecedor);
            nota.AdicionaProduto(produto);

            Console.WriteLine($"Nota Fiscal gerada para {nota.Cliente.Nome}");
            Console.WriteLine($"Fornecedor: {nota.Fornecedor.RazaoSocial}");
            Console.WriteLine($"Produto: {nota.Produtos[0].Descricao} - R$ {nota.Produtos[0].Valor}");
        }
    }
}
