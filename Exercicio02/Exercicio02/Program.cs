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
            int qtCarro = 0;
            Carro[] carros = new Carro[300];

            int qtCaminhao = 0;
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
                        carros[qtCarro] = CadastraCarro();
                        qtCarro++;
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

        static public Carro CadastraCarro()
        {

            Console.Clear();
            Carro carro = new Carro();

            Console.Write("Digite o nome do fabricante do carro: ");
            carro.Fabricante1 = Console.ReadLine();

            Console.Write("Digite o modelo do carro: ");
            carro.Modelo1 = Console.ReadLine();

            bool ok = false;
            do
            {
                try
                {
                    Console.Write("Digite o ano do carro: ");
                    carro.Ano1 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite um número inteiro! Pressione uma tecla para continuar");
                    Console.ReadKey();
                }

            } while (!ok);
            ok = false;
            do
            {
                try
                {
                    Console.Write("Digite o número de portas do carro: ");
                    carro.NrPortas1 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite um número inteiro! Pressione uma tecla para continuar");
                    Console.ReadKey();
                }

            } while (!ok);
            ok = false;

            do
            {
                try
                {
                    Console.Write("Digite a cor do carro: ");
                    carro.Cor1 = Console.ReadLine();
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite um número inteiro! Pressione uma tecla para continuar");
                    Console.ReadKey();
                }

            } while (!ok);
            ok = false;

            do
            {
                try
                {

                    Console.Write("Digite a quantidade de passageiros que cabem no carro: ");
                    carro.QtPassageiros1 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite um número inteiro! Pressione uma tecla para continuar");
                    Console.ReadKey();
                }

            } while (!ok);
            ok = false;

            do
            {
                try
                {
                    Console.Write("Digite a capacidade do porta malas: ");
                    carro.CapacidadePortaMala1 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite um número inteiro! Pressione uma tecla para continuar");
                    Console.ReadKey();
                }

            } while (!ok);
            ok = false;

            Console.Write("O carro tem bagageiro [ S | N ] ? ");
            if (Console.ReadLine().ToUpper() == "S")
            {
                carro.Bagageiro1 = true;
            }
            else
            {
                carro.Bagageiro1 = false;
            }

           

            Console.Write("Carro cadastrado com sucesso! Pressione uma tecla para continuar.");
            Console.ReadKey();

            return carro;
        }
    }
}
