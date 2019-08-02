using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    abstract class Veiculo
    {
        private string Modelo;
        private string Fabricante;
        private int Ano;
        private string Cor;
        private int NrPortas;
        private string placa;

        public Veiculo(string modelo, string fabricante, int ano, string cor, int nrPortas, string placa1)
        {
            Modelo1 = modelo;
            Fabricante1 = fabricante;
            Ano1 = ano;
            Cor1 = cor;
            NrPortas1 = nrPortas;
            placa = placa1;
        }

        protected Veiculo()
        {
        }

        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public string Fabricante1 { get => Fabricante; set => Fabricante = value; }
        public int Ano1 { get => Ano; set => Ano = value; }
        public string Cor1 { get => Cor; set => Cor = value; }
        public int NrPortas1 { get => NrPortas; set => NrPortas = value; }
        public string Placa1 { get => placa; set => placa = value;  }
    }
}
