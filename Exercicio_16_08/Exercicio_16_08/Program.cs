using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_16_08
{
    class Program
    {
        static int[] arr = new int[4];
        static void Main(string[] args)
        {
            Carregar();
            Mostrar();
            Multiplicar();
            Console.ReadKey();
        }

        static void Carregar()
        {
            Random random = new Random();
            for (int i =0; i < arr.Length; i++)
            {
                arr[i] =  random.Next(1,999);
            }
        }

        static void Mostrar()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("O {0}º numero é: {1}",(i+1),arr[i]);
            }
        }

        static void Multiplicar()
        {
            Random random = new Random();
            int x = random.Next(1, 99);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("O resultado da multiplicação de {0}º x {1} é: {2}", (i + 1),x,(arr[i] * x));
            }
        }
    }
}
