using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraVeiculos
{
    public class Veiculo
    {
        private string _modelo;
        private string _marca;
        private DateOnly _ano;
        private int _nDias;
        private double _aluguelDia;

        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public DateOnly Ano { get => _ano; set => _ano = value; }
        public int nDias { get => _nDias; set => _nDias = value; }
        public double AluguelDia { get => _aluguelDia; set => _aluguelDia = value; }

        public Veiculo(string modelo, string marca, DateOnly ano,int nDias, double aluguelDia)
        {
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _nDias = nDias;
            _aluguelDia = aluguelDia;
        }


        public virtual double CalcularAluguelDia(int dias)
        {
            return AluguelDia * dias;
        }
    }
}
