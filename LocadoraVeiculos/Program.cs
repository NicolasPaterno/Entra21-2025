using System.Security.Cryptography.X509Certificates;

namespace LocadoraVeiculos
{
    public class Program
    {

        public static void Main(String[] args)
        {
            while (true)
            {
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        string modelo = Console.ReadLine();
                        string marca = Console.ReadLine();
                        DateOnly ano = DateOnly.Parse(Console.ReadLine());
                        double aluguelDia = double.Parse(Console.ReadLine());
                        int diasM = int.Parse(Console.ReadLine());
                        Moto moto = new Moto(modelo, marca, ano,diasM, aluguelDia);
                        MostrarMoto(moto);
                        break;

                    case 2:
                        string modeloC = Console.ReadLine();
                        string marcaC = Console.ReadLine();
                        DateOnly anoC = DateOnly.Parse(Console.ReadLine());
                        double aluguelDiaC = double.Parse(Console.ReadLine());
                        int diasC = int.Parse(Console.ReadLine());
                        Carro carro = new Carro(modeloC, marcaC, anoC,diasC, aluguelDiaC);
                        break;

                    case 3:
                        string modeloCaminhao = Console.ReadLine();
                        string marcaCaminhao = Console.ReadLine();
                        DateOnly anoCaminhao = DateOnly.Parse(Console.ReadLine());
                        double aluguelDiaCaminhao = double.Parse(Console.ReadLine());
                        int diasCaminhao = int.Parse(Console.ReadLine());
                        Caminhao caminhao = new Caminhao(modeloCaminhao, marcaCaminhao, anoCaminhao,diasCaminhao, aluguelDiaCaminhao);
                        break;
                }
            }
            

            void MostrarMoto(Moto moto)
            {
                Console.WriteLine($" Modelo: {moto.Modelo}| Marca: {moto.Marca} | Ano:{moto.Ano} | aluguel por {moto.} dia: R${moto.CalcularAluguelDia} ");
            }


        }
    }

}