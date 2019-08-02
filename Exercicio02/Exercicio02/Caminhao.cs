using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Caminhao : Veiculo
    {
        private int nrEixos;
        private double PesoMaximoCarga;
        private bool temCarga;

        public Caminhao()
        {
        }

        public Caminhao(int nrEixos, double pesoMaximoCarga1, bool temCarga,
                        string modelo, string fabricante, int ano, string cor, int nrPortas, string placa) : 
                        base(modelo, fabricante, ano, cor, nrPortas, placa)
        {
            NrEixos = nrEixos;
            PesoMaximoCarga1 = pesoMaximoCarga1;
            TemCarga = temCarga;
        }

        public int NrEixos { get => nrEixos; set => nrEixos = value; }
        public double PesoMaximoCarga1 { get => PesoMaximoCarga; set => PesoMaximoCarga = value; }
        public bool TemCarga { get => temCarga; set => temCarga = value; }
    }
}
