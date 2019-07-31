using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro[] carros = new Carro[300];
            Caminhao[] caminhaos = new Caminhao[200];

            int opcao = 9;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Cadastrar Carro");
                Console.WriteLine("2- Cadastrar Caminhão");
                Console.WriteLine("3- Consultar por Placa");
                Console.WriteLine("4- Consultar Caminhão por Modelo/Marca");
                Console.WriteLine("5- Consultar Carro por Cor");
                Console.WriteLine("6- Exibir todos os Carros cadastrados");
                Console.WriteLine("7- Exibir todos os Caminhões cadastrados");
                Console.WriteLine("");
                Console.Write("Digite o numero da opção desejada: ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }catch(Exception e)
                {
                    opcao = 9;
                }

                switch (opcao)
                {
                    case 0:
                        break;
                    case 1:
                        
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opção Inválida, pressione uma tecla para continuar");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }

        public Carro CadastraCarro()
        {
            Carro carro = new Carro();
            return carro;
        }
    }
}
