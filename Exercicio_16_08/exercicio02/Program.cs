using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Program
    {
        static public int[,] matriz = new int[3, 4];
        static void Main(string[] args)
        {
            Carregar();
            Somar();
            MostraMaiorMenor();
            MostrarMedia();
            Console.ReadKey();
        }

        static public void Carregar()
        {
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0);i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = random.Next(0, 50);
                    Console.Write(" "+matriz[i, j]+" ");
                }
                Console.WriteLine("");
            }
        }

        static public int Somar()
        {
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
            }
            Console.WriteLine("A soma de todos os numeros é: "+soma);
            return soma;
        }

        static public void MostraMaiorMenor()
        {
            int menor = matriz[0,0];
            int maior = matriz[0,0];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] < menor)
                    {
                        menor = matriz[i, j];

                    }
                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }
            Console.WriteLine("O menor numero é: {0} e o maior número é:{1}",menor, maior);
        }

        static public void MostrarMedia()
        {
            Console.WriteLine("A média dos numeros é: {0}", (Somar() / (matriz.GetLength(0) + matriz.GetLength(1))));
        }
    }
}
