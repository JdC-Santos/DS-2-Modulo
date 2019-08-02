using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Carro : Veiculo
    {
        private int CapacidadePortaMala;
        private bool Bagageiro;
        private int QtPassageiros;

        public Carro()
        {
        }

        public Carro(int capacidadePortaMala1, bool bagageiro1, int qtPassageiros1, 
                     string modelo, string fabricante, int ano, string cor, int nrPortas, string placa) : 
                     base(modelo, fabricante, ano, cor, nrPortas, placa)
        {
            CapacidadePortaMala1 = capacidadePortaMala1;
            Bagageiro1 = bagageiro1;
            QtPassageiros1 = qtPassageiros1;
        }

        public int CapacidadePortaMala1 { get => CapacidadePortaMala; set => CapacidadePortaMala = value; }
        public bool Bagageiro1 { get => Bagageiro; set => Bagageiro = value; }
        public int QtPassageiros1 { get => QtPassageiros; set => QtPassageiros = value; }
    }
}
