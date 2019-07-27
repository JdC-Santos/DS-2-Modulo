using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            prod.SetId(1);
            prod.SetNome("Notebook");
            prod.SetValor(1123.22);
            prod.SetDescricao("um aparelho bem bacana");

            Cliente cli = new Cliente();
            cli.SetId(1);
            cli.SetNome("JdC");
            cli.PegarProduto(prod);

            Console.WriteLine("O cliente {0} pegou o produto {1}", cli.GetNome(), cli.Produto.GetNome());
            Console.WriteLine(prod.GetDescricao());
            Console.ReadKey();
        }
    }
}
