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
        static void Main(string[] args)
        {
            string arquivo = "";
            string nome = "";

            Console.WriteLine("Digite o caminho para o arquivo");
            Console.WriteLine(@"Exemplo: caminho\arquivo.bin");
            arquivo = Console.ReadLine();

            Console.WriteLine("Digite o seu nick: ");
            nome = Console.ReadLine();

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
                            Console.WriteLine("Mensagem :" + rd.ReadLine());
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
            Console.WriteLine("\n Digite A sua mensagem: ");
            string mensagem = Console.ReadLine();
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

            bw.Write(mensagem + "\n");

            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}
