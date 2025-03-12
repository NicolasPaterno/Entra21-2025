namespace POO_Lanchonete
{
    public class Product
    {
        private string _name;
        private double _price;
        private long _id;

        public Product(string name, double price, long id)
        {
            _name = name;
            _price = price;
            _id = id;
        }

        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public long ID { get => _id; set => _id = value; } 


        public override string ToString()
        {
            return $"Produto: {_name} Preço: {_price}";
        }
    }
}