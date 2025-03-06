namespace POO_Lanchonete
{
    public class Product
    {
        private string _name;
        private double _price;

        public Product(string name, double price)
        {
            _name = name;
            _price = price;

        }

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }


        public override string ToString()
        {
            return $"Produto: {_name} Preço: {_price}";
        }
    }
}