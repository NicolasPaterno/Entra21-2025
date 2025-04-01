using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    internal class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, DateOnly ano, int nDias, double aluguelDia) : base(modelo, marca, ano, nDias, aluguelDia)
        {
        }

        public override double CalcularAluguelDia(int dias)
        {
            AluguelDia = base.CalcularAluguelDia(dias);
            return AluguelDia += (AluguelDia * 0.2);
        }
    }
}
