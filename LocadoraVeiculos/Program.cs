using System.Security.Cryptography.X509Certificates;

namespace LocadoraVeiculos
{
    public class Program
    {

        public static void Main(String[] args)
        {
            List<object> veiculos = new List<object>();

            while (true)

            {
                Console.WriteLine("Menu");
                Console.WriteLine("________________________________________");
                Console.WriteLine("1. Adicionar Moto");
                Console.WriteLine("2. Adicionar Carro");
                Console.WriteLine("3. Adicionar Caminhão");

                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        NewMoto(veiculos);
                        break;

                    case 2:
                        NewCar(veiculos);
                        break;

                    case 3:
                        NewCaminhao(veiculos);
                        break;

                    case 4:
                        ShowData(veiculos);
                        break;
                }
            }

            static void NewMoto(List<object> veiculos)
            {
                Console.Write("modelo: ");
                string modelo = Console.ReadLine();
                Console.Write("marca: ");
                string marca = Console.ReadLine();
                Console.Write("Ano do Veículo (dd-mm-yyy): ");
                DateOnly ano = DateOnly.Parse(Console.ReadLine());
                Console.Write("Aluguel por dia: R$");
                double aluguelDia = double.Parse(Console.ReadLine());
                Console.Write("Duração do aluguel em dias: ");
                int diasM = int.Parse(Console.ReadLine());
                Moto moto = new Moto(modelo, marca, ano, diasM, aluguelDia);
                veiculos.Add(moto);
            }

            static void NewCar(List<object> veiculos)
            {
                Console.Write("modelo: ");
                string modeloC = Console.ReadLine();
                Console.Write("marca: ");
                string marcaC = Console.ReadLine();
                Console.Write("Ano do Veículo (dd-mm-yyy): ");
                DateOnly anoC = DateOnly.Parse(Console.ReadLine());
                Console.Write("Aluguel por dia: R$");
                double aluguelDiaC = double.Parse(Console.ReadLine());
                Console.Write("Duração do aluguel em dias: ");
                int diasC = int.Parse(Console.ReadLine());
                Carro carro = new Carro(modeloC, marcaC, anoC, diasC, aluguelDiaC);
                veiculos.Add(carro);
            }

            static void NewCaminhao(List<object> veiculos)
            {
                Console.Write("modelo: ");
                string modeloCaminhao = Console.ReadLine();
                Console.Write("marca: ");
                string marcaCaminhao = Console.ReadLine();
                Console.Write("Ano do Veículo (dd-mm-yyy): ");
                DateOnly anoCaminhao = DateOnly.Parse(Console.ReadLine());
                Console.Write("Aluguel por dia: R$");
                double aluguelDiaCaminhao = double.Parse(Console.ReadLine());
                Console.Write("Duração do aluguel em dias: ");
                int diasCaminhao = int.Parse(Console.ReadLine());
                Caminhao caminhao = new Caminhao(modeloCaminhao, marcaCaminhao, anoCaminhao, diasCaminhao, aluguelDiaCaminhao);
                veiculos.Add(caminhao);
            }

            static void ShowData(List<object> veiculos)
            {
                foreach (var veiculo in veiculos)
                {
                    if (veiculo is Carro carro)
                    {
                        ShowCarro(carro);
                    }
                    else if (veiculo is Moto moto)
                    {
                        ShowMoto(moto);
                    }
                    else if (veiculo is Caminhao caminhao)
                    {
                        ShowCaminhao(caminhao);
                    }
                }
            }

            static void ShowCarro(Carro carro)
            {
                Console.WriteLine($"Modelo: {carro.Modelo}| Marca: {carro.Marca} | Ano:{carro.Ano} | \naluguel R${carro.AluguelDia} por {carro.nDias} dias: R${carro.CalcularAluguelDia(carro.nDias)}\n ");
            }
            static void ShowMoto(Moto moto)
            {
                Console.WriteLine($"Modelo: {moto.Modelo}| Marca: {moto.Marca} | Ano:{moto.Ano} | \naluguel R${moto.AluguelDia} por {moto.nDias} dias: R${moto.CalcularAluguelDia(moto.nDias)}\n ");
            }
            static void ShowCaminhao(Caminhao caminhao)
            {
                Console.WriteLine($"Modelo: {caminhao.Modelo}| Marca: {caminhao.Marca} | Ano:{caminhao.Ano} | \naluguel R${caminhao.AluguelDia} por {caminhao.nDias} dias: R${caminhao.CalcularAluguelDia(caminhao.nDias)}\n ");
            }

        }
    }

}