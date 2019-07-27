using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Produto
    {
        private int Id;
        private string Nome;
        private string Descricao;
        private double Valor;

        public int GetId()
        {
            return Id;
        }
        public void SetId(int id)
        {
            Id = id;
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string ds)
        {
            Descricao = ds;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double vl)
        {
            Valor = vl;
        }
    }
}
