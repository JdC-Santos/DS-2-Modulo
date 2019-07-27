using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Cliente: User
    {
        private double VlPagamento
        {
            get { return VlPagamento; }
            set { VlPagamento = value; }
        }
        private int Parcelas;
        public Produto Produto;

        public bool PegarProduto(Produto prod)
        {
            try
            {
                Produto = prod;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
