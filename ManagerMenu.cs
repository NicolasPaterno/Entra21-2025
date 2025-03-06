namespace POO_Lanchonete
{
    public class ManagerMenu
    {
        public Dictionary<long, Product> products;
        private static long currentId = 0;

        public ManagerMenu()
        {
            this.products = new Dictionary<long, Product>();
        }

        public void AddMenu(Product product)
        {
            long idMenu = ++currentId;
            products.Add(idMenu, product);
            Console.WriteLine($"Produto {product.Name} Adicionado com sucesso ID {idMenu}");
        }

        public void RemoveMenu(long idMenu)
        {
            if (products.ContainsKey(idMenu))
            {
                products.Remove(idMenu);
                Console.WriteLine($"Produto com ID {idMenu} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com ID {idMenu} não encontrado.");
            }
        }

        public void ListarMenu()
        {
            foreach (KeyValuePair<long, Product> entry in products)
            {
                Console.WriteLine($"ID: {entry.Key}, Produto: {entry.Value.Name}, Preço: {entry.Value.Price}");
            }
        }
    }
}
