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
            Console.WriteLine("Menu de pedidos");
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Produto no cardápio");
                Console.WriteLine("2. Listar cardápio ");
                Console.WriteLine("3. Adicionar Pedido");
                Console.WriteLine("4. Remover Produto");
                Console.WriteLine("5. Sair");
                Console.WriteLine("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Número de produtos a serem listados: ");
                        int nProdutos = int.Parse(Console.ReadLine());
                        int i = 0;
                        while (i < nProdutos)
                        {
                            Console.WriteLine("adicione um item no cardápio");
                            string name = Console.ReadLine();
                            Console.WriteLine("preço:");
                            double price = double.Parse(Console.ReadLine());
                            Product product = new Product(name, price);
                            managerMenu.AddMenu(product);
                            i++;
                        }
                        break;

                    case 2:
                        managerMenu.ListarMenu();
                        break;

                    case 3:
                        Console.WriteLine("Cardápio\n-----------------------");
                        Console.WriteLine();
                        if (managerMenu.products.Count == 0)
                        {
                            break;
                        }
                        managerMenu.ListarMenu();

                        while (true)
                        {
                            Console.WriteLine("Digite o ID do produto para adicionar ao pedido ou 0 para sair.");
                            int op = int.Parse(Console.ReadLine());

                            if (op == 0)
                                break;

                            Product selectedProduct = managerMenu.GetProductById(op);

                            if (selectedProduct != null)
                            {
                                managerOrder.AddOrder(selectedProduct);
                                Console.WriteLine($"{selectedProduct.Name} foi adicionado ao pedido.");
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

                    default:
                        Console.WriteLine("opção inexistente!");
                        break;
                }
            }
        }
    }
}
