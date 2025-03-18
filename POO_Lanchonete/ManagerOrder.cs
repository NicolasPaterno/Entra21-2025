namespace POO_Lanchonete
{
    public class ManagerOrder
    {
        private List<List<Product>> orders;
        private List<Product> tempOrder;
        private static long currentOrderId = 0;

        public ManagerOrder()
        {
            this.orders = new List<List<Product>>();
            this.tempOrder = new List<Product>();
        }

        public void AddOrder(Product product)
        {
            tempOrder.Add(product);
            Console.WriteLine($"Produto {product.Name} adicionado ao pedido!");
        }

        public void FinalizarPedido()
        {
            if (tempOrder.Count == 0)
            {
                Console.WriteLine("O pedido está vazio. Adicione produtos antes de finalizar.");
                return;
            }

            orders.Add(new List<Product>(tempOrder));
            currentOrderId++;
            tempOrder.Clear();

            Console.WriteLine($"Pedido {currentOrderId} finalizado com sucesso!");
        }

        public void RemoveOrder(long id)
        {
            bool found = false;

            foreach (List<Product> order in orders)
            {
                foreach (Product product in order)
                {
                    if (product.ID == id)
                    {
                        order.Remove(product);
                        Console.WriteLine($"Produto {product.Name} removido do pedido.");
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }

            if (!found)
            {
                Console.WriteLine("Produto não encontrado em nenhum pedido.");
            }
        }

        public void ListarOrder()
        {
            double sum = 0;
            if (orders.Count == 0)
            {
                Console.WriteLine("Nenhum pedido realizado.");
                return;
            }

            Console.WriteLine("\nPedidos Realizados:\n ____________________________________");
            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"Pedido {i + 1}:");
                foreach (Product product in orders[i])
                {
                    sum += product.Price;
                    Console.WriteLine($"Produto: {product.Name}, Preço: R${product.Price:F2}");
                }
                Console.WriteLine($"total: R${sum}");
                Console.WriteLine("_____________________________________________________________");
            }
        }
    }
}
