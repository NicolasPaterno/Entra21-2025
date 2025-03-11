using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_Lanchonete
{
    public class ManagerOrder
    {
        public Dictionary<long, Product> products;  // Armazena todos os produtos
        public Dictionary<long, Dictionary<long, Product>> orders; // Armazena pedidos (cada um com produtos)

        private static long currentOrderId = 0;
        private static long currentProductId = 0;

        public ManagerOrder()
        {
            this.products = new Dictionary<long, Product>();
            this.orders = new Dictionary<long, Dictionary<long, Product>>();
        }

        public void AddOrder(Product product)
        {
            long idProduct = ++currentProductId;
            long idOrder = ++currentOrderId;

            // Adiciona o produto no dicionário geral de produtos
            products.Add(idProduct, product);

            // Cria um novo pedido contendo esse produto
            Dictionary<long, Product> orderProducts = new Dictionary<long, Product>
        {
            { idProduct, product }
        };

            // Adiciona o pedido no dicionário de pedidos
            orders.Add(idOrder, orderProducts);
        }

        public void ListarOrder()
        {
            double sumOrder = 0;
            if (products.Count == 0)
            {
                Console.WriteLine("Não há produtos no cardápio!");
                return;
            }
            foreach (var order in orders)
            {
                Console.WriteLine($"Pedido nº{currentOrderId}");
               foreach (var product in order.Value)
                {
                    Console.WriteLine($"  - Produto: {product.Value.Name}, Preço: R${product.Value.Price}");
                    sumOrder += product.Value.Price;
                }
            }
                    Console.WriteLine($"Total R${sumOrder}");
        }

        public void RemoveOrder(long id)
        {
            products.Remove(id);
        }



    }
}
