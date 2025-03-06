using System;
using System.Collections.Generic;

namespace POO_Lanchonete
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ManagerMenu managerMenu = new ManagerMenu();
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
                        managerMenu.ListarMenu();
                        break;

                    default:
                        Console.WriteLine("opção inexistente!");
                        break;
                }
            }
        }
    }
}
