using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    internal class Moto : Veiculo
    {
        public Moto(string modelo, string marca, DateOnly ano, int nDias, double aluguelDia) : base(modelo, marca, ano, nDias, aluguelDia)
        {
        }

        public override double CalcularAluguelDia(int dias)
        {
            AluguelDia *= dias;
            return AluguelDia - (AluguelDia * 0.1);
        }


    }
}
