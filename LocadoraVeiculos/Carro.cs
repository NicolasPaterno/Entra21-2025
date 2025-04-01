using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    public class Carro : Veiculo
    {
        public Carro(string modelo, string marca, DateOnly ano, int nDias, double aluguelDia) : base(modelo, marca, ano,nDias, aluguelDia)
        {
        }
        public override double CalcularAluguelDia(int dias)
        {
            return base.CalcularAluguelDia(dias);
        }
    }
}
