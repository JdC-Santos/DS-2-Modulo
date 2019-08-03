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
                        caminhaos[qtCaminhao] = CadastraCaminhao();
                        qtCaminhao++;
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Digite o numero da placa que deseja procurar: ");
                        string placa = Console.ReadLine();
                        if (!ConsultaPlaca(placa, carros, caminhaos))
                        {
                            Console.WriteLine("Não existe veiculo com esta placa!");
                        }
                        
                        Console.WriteLine(" Pressione ENTER para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite o modelo/marca do caminhão");
                        Caminhao c1 = BuscaCaminhao(caminhaos, Console.ReadLine());

                        if (c1 == null)
                        {
                            Console.WriteLine("Não foi encontrado nenhum com este modelo/marca");
                        }
                        else
                        {
                            Console.WriteLine("Informações do veiculo:");
                            Console.WriteLine("Fabricante: " + c1.Fabricante1);
                            Console.WriteLine("Modelo: " + c1.Modelo1);
                            Console.WriteLine("Cor: " + c1.Cor1);
                            Console.WriteLine("Ano: " + c1.Ano1);
                            Console.WriteLine("qtd Portas: " + c1.NrPortas1);
                            Console.WriteLine("Placa: " + c1.Placa1);
                            Console.WriteLine("tem carga: " + (c1.TemCarga ? "sim" : "nao"));
                            Console.WriteLine("Nº de Eixos: " + c1.NrEixos);
                            Console.WriteLine("Peso maximo da carga (kg)" + c1.PesoMaximoCarga1);
                        }
                        Console.WriteLine("Pressione uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite a cor do veiculo que deseja buscar");
                        string cor = Console.ReadLine();

                        if (!BuscaCor(cor, carros, caminhaos))
                        {
                            Console.WriteLine("Não foi encontrado nenhum veiculo com essa cor");
                        }
                        Console.Write("Pressione uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        if (!ListaCarros(carros)){
                            Console.WriteLine("Nenhum carro cadastrado");
                        }
                        Console.WriteLine("Pressione uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        if (!ListaCaminhoes(caminhaos))
                        {
                            Console.WriteLine("Nenhum caminhao cadastrado");
                        }
                        Console.WriteLine("Pressione uma tecla para continuar");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
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

            Console.Write("Digite a placa do veiculo: ");
            carro.Placa1 = Console.ReadLine();

            Console.Write("Carro cadastrado com sucesso!\nPressione uma tecla para continuar.");
            Console.ReadKey();

            return carro;
        }

        static public Caminhao CadastraCaminhao()
        {

            Console.Clear();
            Caminhao carro = new Caminhao();

            Console.Write("Digite o nome do fabricante do caminhao: ");
            carro.Fabricante1 = Console.ReadLine();

            Console.Write("Digite o modelo do caminhao: ");
            carro.Modelo1 = Console.ReadLine();

            bool ok = false;
            do
            {
                try
                {
                    Console.Write("Digite o ano do caminhao: ");
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
                    Console.Write("Digite o número de portas do caminhao: ");
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

                    Console.Write("Digite a quantidade de eixos que o caminhão tem: ");
                    carro.NrEixos = int.Parse(Console.ReadLine());
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
                    Console.Write("Digite a capacidade de carga: ");
                    carro.PesoMaximoCarga1 = int.Parse(Console.ReadLine());
                    ok = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite um número inteiro! Pressione uma tecla para continuar");
                    Console.ReadKey();
                }

            } while (!ok);
            ok = false;

            Console.Write("O caminhao está com carga [ S | N ] ? ");
            if (Console.ReadLine().ToUpper() == "S")
            {
                carro.TemCarga = true;
            }
            else
            {
                carro.TemCarga = false;
            }

            Console.Write("Digite a placa do veiculo: ");
            carro.Placa1 = Console.ReadLine();

            Console.Write("Carro cadastrado com sucesso! Pressione uma tecla para continuar.");
            Console.ReadKey();

            return carro;
        }

        static public bool ConsultaPlaca(string placa, Carro[] carros, Caminhao[] caminhoes)
        {
            bool encontrou = false;
            foreach (Carro carro in carros)
            {
                if (carro != null && carro.Placa1 == placa)
                {

                    ShowCarro(carro, "1");
                    encontrou = true;
                }
            }

            foreach (Caminhao caminhao in caminhoes)
            {
                int nr = 1;
                if (caminhao != null && caminhao.Placa1 == placa)
                {
                    ShowCaminhao(caminhao, nr.ToString());
                    encontrou = true;
                }
            }

            return encontrou;
        }

        static public Caminhao BuscaCaminhao(Caminhao[] caminhoes, string modelo)
        {
            foreach (Caminhao caminhao in caminhoes)
            {
                if (caminhao != null && caminhao.Modelo1 == modelo)
                {
                    return caminhao;
                }
            }
            return null;
        }

        static public bool BuscaCor(string cor, Carro[] carros, Caminhao[] caminhoes)
        {
            bool Encontrou = false;
            foreach (Carro carro in carros)
            {
                int nr = 1;
                if (carro != null && carro.Cor1 == cor)
                {
                    ShowCarro(carro, nr.ToString());
                    nr++;
                    Encontrou = true;
                }
            }

            foreach (Caminhao caminhao in caminhoes)
            {
                int nr = 1;
                if (caminhao != null && caminhao.Cor1 == cor)
                {
                    ShowCaminhao(caminhao, nr.ToString());
                    Encontrou = true;
                    nr++;
                }
            }

            return Encontrou;
        }

        static public bool ListaCarros(Carro[] carros)
        {
            int nr = 1;
            bool encontrou = false;
            foreach(Carro carro in carros)
            {

                if(carro != null)
                {
                    encontrou = true;
                    ShowCarro(carro, nr.ToString());
                    nr++;
                }
            }
            return encontrou;
        }

        static public bool ListaCaminhoes(Caminhao[] caminhoes)
        {
            int nr = 1;
            bool encontrou = false;
            foreach (Caminhao caminhao in caminhoes)
            {

                if (caminhao != null)
                {
                    encontrou = true;
                    ShowCaminhao(caminhao, nr.ToString());
                    nr++;
                }
            }
            return encontrou;
        }

        static public void ShowCarro(Carro carro, string nr = "" )
        {

            Console.WriteLine("Informações do veiculo: Carro");
            Console.WriteLine("Fabricante: " + carro.Fabricante1);
            Console.WriteLine("Modelo: " + carro.Modelo1);
            Console.WriteLine("Cor: " + carro.Cor1);
            Console.WriteLine("Ano: " + carro.Ano1);
            Console.WriteLine("qtd Portas: " + carro.NrPortas1);
            Console.WriteLine("Placa: " + carro.Placa1);
            Console.WriteLine("Qtd Max. Passageiros: " + carro.QtPassageiros1);
            Console.WriteLine("Capacidade Porta malas (kg): " + carro.CapacidadePortaMala1);
            Console.WriteLine("Tem bagageiro: " + (carro.Bagageiro1 ? "sim" : "não"));
            Console.WriteLine("-------------------------------------------------");
        }

        static public void ShowCaminhao(Caminhao caminhao, string nr)
        {

           
            Console.WriteLine("Informações do veiculo: Caminhao ");
            Console.WriteLine("Fabricante: " + caminhao.Fabricante1);
            Console.WriteLine("Modelo: " + caminhao.Modelo1);
            Console.WriteLine("Cor: " + caminhao.Cor1);
            Console.WriteLine("Ano: " + caminhao.Ano1);
            Console.WriteLine("qtd Portas: " + caminhao.NrPortas1);
            Console.WriteLine("Placa: " + caminhao.Placa1);
            Console.WriteLine("tem carga: " + (caminhao.TemCarga ? "sim" : "nao"));
            Console.WriteLine("Nº de Eixos: " + caminhao.NrEixos);
            Console.WriteLine("Peso maximo da carga (kg)" + caminhao.PesoMaximoCarga1);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
