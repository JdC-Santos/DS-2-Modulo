using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;
        private int idade;
        private double altura;

        public Pessoa()
        {
        }

        public Pessoa(string nome, string endereco, string telefone, int idade, double altura)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Idade = idade;
            Altura = altura;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Altura { get => altura; set => altura = value; }

        public void Imprimir()
        {
            Console.WriteLine("O nome deste individuo é: "+nome);
            Console.WriteLine("Supostamente o endereço desta pessoa é: "+endereco);
            Console.WriteLine("Talvez o numero de telefone dele seja este: "+ telefone);
            Console.WriteLine("Acho que ele tem por volta de {0} anos de idade", idade);
            Console.WriteLine("Pelo tamanho da sombra calculando a posição do sol, deve ter {0}m de altura", altura);
        }
    }
}
