using System;
using System.Collections.Generic;

namespace POO_Lanchonete
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            ManagerOrder managerOrder = new ManagerOrder();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Produto no Cardápio");
                Console.WriteLine("2. Listar Cardápio");
                Console.WriteLine("3. Adicionar Pedido");
                Console.WriteLine("4. Listar Pedidos");
                Console.WriteLine("5. Remover Produto do Cardápio");
                Console.WriteLine("6. Remover Produto do Pedido");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Número de produtos a serem adicionados ao cardápio: ");
                        int numMenu = int.Parse(Console.ReadLine());
                        while (numMenu > 0)
                        {
                            Console.Write("Nome do produto: ");
                            string name = Console.ReadLine();

                            Console.Write("Preço do produto: ");
                            if (!double.TryParse(Console.ReadLine(), out double price))
                            {
                                Console.WriteLine("Preço inválido. Tente novamente.");
                                break;
                            }
                            managerMenu.AddMenu(name, price);
                            numMenu--;
                        }
                        break;

                    case 2:
                        managerMenu.ListarMenu();
                        break;

                    case 3:
                        Console.WriteLine("Cardápio \n_____________________________________________________________");
                        managerMenu.ListarMenu();

                        while (true) 
                        {
                            Console.Write("\nDigite o ID do produto para adicionar ao pedido (ou 0 para finalizar): ");

                            if (!long.TryParse(Console.ReadLine(), out long productId))
                            {
                                Console.WriteLine("ID inválido. Tente novamente.");
                                continue; 
                            }

                            if (productId == 0)
                            {
                                Console.WriteLine("Pedido finalizado.");
                                managerOrder.FinalizarPedido();
                                break;
                            }

                            Product selectedProduct = managerMenu.GetProductById(productId);
                            if (selectedProduct != null)
                            {
                                managerOrder.AddOrder(selectedProduct);
                            }
                            else
                            {
                                Console.WriteLine("Produto não encontrado.");
                            }
                        }


                        break;

                    case 4:
                        managerOrder.ListarOrder();
                        break;

                    case 5:
                        managerMenu.ListarMenu();
                        Console.Write("Digite o ID do produto para remover: ");
                        if (!long.TryParse(Console.ReadLine(), out long removeId))
                        {
                            Console.WriteLine("ID inválido.");
                            break;
                        }
                        managerMenu.RemoveMenu(removeId);
                        break;

                    case 6:
                        managerOrder.ListarOrder();
                        Console.Write("Digite o ID do produto para remover do pedido: ");
                        if (!long.TryParse(Console.ReadLine(), out long removeOrderId))
                        {
                            Console.WriteLine("ID inválido.");
                            break;
                        }
                        managerOrder.RemoveOrder(removeOrderId);
                        break;

                    case 7:
                        Console.WriteLine("Saindo...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }
            }
        }
    }
}
