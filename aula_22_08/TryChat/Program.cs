using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryChat
{
    class Program
    {
        static string nome = "";
        static void Main(string[] args)
        {
            string arquivo = "";
            

            Console.WriteLine("Digite o caminho para o arquivo");
            Console.WriteLine(@"Exemplo: caminho\arquivo.bin");
            arquivo = Console.ReadLine();

            Console.WriteLine("Digite o seu nick: ");
            nome = Console.ReadLine();

            if (!File.Exists(arquivo))
            {
                StreamWriter st = new StreamWriter(arquivo,true);
                st.Write("[System]: ");
                st.Write(" Bem vindo \n");
                st.Close();
            }

            AtualizarChat(arquivo);
        }

        static public void AtualizarChat(string caminho)
        {
            StreamReader rd = new StreamReader(caminho);
            rd.Close();
            bool leu = false;
            do
            {

                if (File.Exists(caminho))
                {
                    do
                    {
                        leu = false;
                        try
                        {
                            rd = new StreamReader(caminho);
                            Console.Clear();
                            leu = true;
                        }
                        catch (Exception e)
                        {
                            
                        }
                    } while (!leu);

                    if (leu)
                    {
                        while (!rd.EndOfStream)
                        {
                            Console.WriteLine(rd.ReadLine());
                        }
                        rd.Close();
                    }
                }


                System.Threading.Thread.Sleep(500);
                if (Console.KeyAvailable)
                {
                    Gravar(caminho);                   
                }
                
            } while (true);
        }

        static public void Gravar(string caminho)
        {
            StreamWriter sw = new StreamWriter(caminho, true);

            Console.WriteLine("\n Digite A sua mensagem: ");
            string mensagem = Console.ReadLine();

            sw.Write("[ "+nome+" ]: ");
            sw.Write(mensagem + "\n");
            
            sw.Close();
        }
    }
}
