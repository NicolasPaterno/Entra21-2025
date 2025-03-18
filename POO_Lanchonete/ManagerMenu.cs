namespace POO_Lanchonete
{
    public class ManagerMenu
    {
        private List<Product> products;
        private static long currentId = 0;

        public ManagerMenu()
        {
            this.products = new List<Product>();
        }

        public void AddMenu(string name, double price)
        {
            long idMenu = ++currentId;
            Product product = new Product(name, price, idMenu);
            products.Add(product);
            Console.WriteLine($"Produto {product.Name} adicionado com sucesso! ID: {idMenu}");
        }

        public void RemoveMenu(long idMenu)
        {
            Product productToRemove = null;
            foreach (Product product in products)
            {
                if (product.ID == idMenu)
                {
                    productToRemove = product;
                    break;
                }
            }

            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine($"Produto com ID {idMenu} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com ID {idMenu} não encontrado.");
            }
        }

        public Product GetProductById(long id)
        {
            foreach (Product product in products)
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            return null;
        }

        public void ListarMenu()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Não há produtos no cardápio!");
                return;
            }

            Console.WriteLine("\nCardápio:");
            foreach (Product product in products)
            {
                Console.WriteLine($"ID: {product.ID}, Produto: {product.Name}, Preço: R${product.Price:F2}");
            }
        }
    }
}
