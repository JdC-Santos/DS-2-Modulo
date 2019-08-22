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
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Escrever");
                Console.WriteLine("2 - Ler");
                Console.WriteLine("0 - sair");

                if (int.Parse(Console.ReadLine()) == 1)
                {
                    Console.WriteLine("Digite a sua mensagem");
                    Gravar(Console.ReadLine());
                }
                else if (int.Parse(Console.ReadLine()) == 2)
                {
                    Console.WriteLine("Digite o caminho e nome do arquivo");                    
                    Ler(Console.ReadLine());
                }
                else
                {
                    sair = true;
                }
            } while (!sair);
        }

        static public void Gravar(string mensagem)
        {
            FileStream fs;

            if (File.Exists("msg.bin"))
            {
                fs = new FileStream("msg.bin", FileMode.Append);
            }
            else
            {
                fs = new FileStream("msg.bin", FileMode.Create);
            }

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(mensagem);
            
            bw.Flush();
            bw.Close();
            fs.Close();
        }


    }
}
