using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aula_22_08
{
    class Program
    {
        public struct Usuario{
            public string nome;
            public int dtNascimento;
            public string sexo;
        }
        static void Main(string[] args)
        {
            Cadastrar();
            Mostrar();
            Console.ReadKey();
        }

        static public void Cadastrar()
        {
            bool cadastrar = true;
            Usuario usuario = new Usuario();

            do {
                Console.Clear();
                Console.WriteLine("Deseja cadastrar um usuario? <S / N>");
                if(Console.ReadLine().ToUpper() == "S")
                {
                    Console.Write("Digite o nome do usuario: ");
                    usuario.nome = Console.ReadLine();
                    Console.Write("Digite a data de nascimento do usuario: ");
                    usuario.dtNascimento = int.Parse(Console.ReadLine());
                    Console.Write("Digite o sexo do usuario: ");
                    usuario.sexo = Console.ReadLine();

                    Gravar(usuario);
                }
                else
                {
                    cadastrar = false;
                }
            } while (cadastrar);
        }
        static public void Gravar(Usuario usuario)
        {
            FileStream fs;

            if (File.Exists("usuarios.bin"))
            {
                fs = new FileStream("usuarios.bin", FileMode.Append);
            }
            else
            {
                fs = new FileStream("usuarios.bin", FileMode.Create);
            }

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(usuario.nome);
            bw.Write(usuario.dtNascimento);
            bw.Write(usuario.sexo);

            bw.Flush();
            bw.Close();
            fs.Close();
        }

        static public void Mostrar()
        {
            FileStream fs = new FileStream("usuarios.bin",FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            while(br.PeekChar() > -1)
            {
                Console.WriteLine("nome: {0}\ndata de nascimento: {1}\nsexo:{2}", br.ReadString(),br.ReadInt32(), br.ReadString());
            }
            br.Close();
            fs.Close();
        }
    }
}
