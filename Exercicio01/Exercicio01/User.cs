using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    abstract class User
    {
        private int Id;
        private string Nome;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }
        public string GetNome() {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}
