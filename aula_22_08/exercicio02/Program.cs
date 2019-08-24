using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            string caminhoArquivo = "";
            int opc = 9;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Escrever");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("0 - sair");

                try
                {
                    opc = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Digite uma opcao válida");
                    Console.ReadKey();
                }

                if (opc ==  1)
                {
                    if (caminhoArquivo.Length < 1)
                    {
                        Console.WriteLine("Digite o caminho para o arquivo");
                        Console.WriteLine(@"Exemplo: caminho\arquivo.bin");
                        caminhoArquivo = Console.ReadLine();
                    }

                    Console.WriteLine("Digite a sua mensagem");
                    Gravar(Console.ReadLine(), caminhoArquivo);
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Digite o caminho e nome do arquivo");               
                    Ler(Console.ReadLine());
                    Console.WriteLine("Pressione uma tecla para voltar...");
                    Console.ReadKey();
                }
                else if(opc == 0)
                {
                    sair = true;
                }
            } while (!sair);
        }

        static public void Gravar(string mensagem,string caminho)
        {
            FileStream fs;

            if (File.Exists(caminho))
            {
                fs = new FileStream(caminho, FileMode.Append);
            }
            else
            {
                fs = new FileStream(caminho, FileMode.Create);
            }

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(mensagem+"\n");
            
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        static public void Ler(string caminho)
        {
            if (File.Exists(caminho))
            {
                StreamReader rd = new StreamReader(caminho);
                
                while (!rd.EndOfStream)
                {
                    Console.WriteLine("Mensagem :" + rd.ReadLine());
                }
                rd.Close();
            }
            else
            {
                Console.WriteLine("Este arquivo nao existe, verifique o caminho e o nome do arquivo");
            }
            
        }
    }
}
