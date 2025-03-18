namespace ContaBanco
{
    public class Program
    {
        private ContaBancaria contaBancaria;
        private const double BONUS_PERCENTUAL = 0.005; 
        private const double TAXA_SAQUE = 5.00; 

        public void Menu()
        {
            Console.WriteLine("Menu\n__________________________________________");
            Console.WriteLine("1. Cadastrar conta");
            Console.WriteLine("2. Depositar");
            Console.WriteLine("3. Sacar");
            Console.WriteLine("4. Exibir saldo da conta");
            Console.WriteLine("5. Sair");
        }

        public void InMenu()
        {
            int op;
            do
            {
                Console.Clear();
                Menu();
                Console.Write("\nDigite sua opção: ");

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Opção inválida! Digite um número.");
                    continue;
                }

                switch (op)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        if (contaBancaria != null)
                            DepositarMenu();
                        else
                            Console.WriteLine("Crie uma conta primeiro!");
                        break;
                    case 3:
                        if (contaBancaria != null)
                            SacarMenu();
                        else
                            Console.WriteLine("Crie uma conta primeiro!");
                        break;
                    case 4:
                        if (contaBancaria != null)
                            ExibirSaldoMenu();
                        else
                            Console.WriteLine("Crie uma conta primeiro!");
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                if (op != 5)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            } while (op != 5);
        }

        public void CreateAccount()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== Criação de Nova Conta ===");
                Console.Write("Número da conta: ");
                int numeroConta = int.Parse(Console.ReadLine());

                Console.Write("Titular: ");
                string titular = Console.ReadLine().ToUpper();

                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.Write("Tipo de conta (1 - Corrente, 2 - Poupança): ");
                int tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    contaBancaria = new ContaCorrente(numeroConta, titular, saldo);
                    Console.WriteLine("Conta Corrente criada com sucesso!");
                }
                else if (tipo == 2)
                {
                    contaBancaria = new ContaPoupanca(numeroConta, titular, saldo);
                    Console.WriteLine("Conta Poupança criada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Tipo de conta inválido!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar conta: {ex.Message}");
            }
        }

        public void DepositarMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== Depósito ===");
                Console.Write("Valor do depósito: ");
                double valor = double.Parse(Console.ReadLine());

                double novoSaldo;
                if (contaBancaria is ContaPoupanca)
                {
                    double bonus = valor * BONUS_PERCENTUAL;
                    novoSaldo = contaBancaria.Depositar(valor + bonus);
                }
                else
                {
                    novoSaldo = contaBancaria.Depositar(valor);
                }
                Console.WriteLine($"Depósito realizado! Novo saldo: R${novoSaldo:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao depositar: {ex.Message}");
            }
        }

        public void SacarMenu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== Saque ===");
                Console.Write("Valor do saque: ");
                double valor = double.Parse(Console.ReadLine());

                double novoSaldo;
                if (contaBancaria is ContaCorrente)
                {
                    double valorTotal = valor + TAXA_SAQUE;
                    novoSaldo = contaBancaria.Sacar(valorTotal);
                }
                else
                {
                    novoSaldo = contaBancaria.Sacar(valor);
                }
                Console.WriteLine($"Saque realizado! Novo saldo: R${novoSaldo:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao sacar: {ex.Message}");
            }
        }

        public void ExibirSaldoMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Saldo da Conta ===");
            contaBancaria.ExibirSaldo();
        }

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.InMenu();
        }
    }
}