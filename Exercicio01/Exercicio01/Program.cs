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
            Cliente[] ArrCli = new Cliente[3];
            Produto[] ArrProd = new Produto[3];

            for (int i = 0; i < 3; i++)
            {
                ArrProd[i] = new Produto();
                ArrProd[i].SetId(i+1);
                Console.WriteLine("Informações do {0}º produto", (i+1));
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Digite o nome do produto: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                ArrProd[i].SetNome(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Digite a descrição do produto: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                ArrProd[i].SetDescricao(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Digite o valor do produto: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                ArrProd[i].SetValor(double.Parse(Console.ReadLine()));
                Console.Clear();
                Console.ResetColor();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Informações do {0}º cliente", (i + 1));
                Console.WriteLine("");

                ArrCli[i] = new Cliente();
                ArrCli[i].SetId(i+1);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Digite o nome do cliente: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                ArrCli[i].SetNome(Console.ReadLine());

                Console.Clear();
                Console.ResetColor();
            }

            for(int i =0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Quais destes produtos o Cliente {0} comprou?", ArrCli[i].GetNome());
                Console.ForegroundColor = ConsoleColor.Yellow;

                foreach (Produto prod in ArrProd)
                {

                    Console.WriteLine("Código do produto: {0}",prod.GetId());
                    Console.WriteLine("Nome do produto: {0}", prod.GetNome());
                    Console.WriteLine("Descrição do produto: {0}", prod.GetDescricao());
                    Console.WriteLine("Valor do produto: {0}", prod.GetValor());
                    Console.WriteLine("---------------------------------------------------");
                }

                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();

            }

            Console.ReadKey();
        }
    }
}
