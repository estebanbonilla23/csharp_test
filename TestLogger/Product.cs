namespace Store
{
    internal class Product
    {
        public string name { get; set; }
        public int price { get; set; }
        public int stock { get; set; }

        public Product(String name, int price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public override string ToString()
        {
            return string.Format("name: '{0}' price '{1}' stock '{2}'", this.name, this.price, this.stock);
        }
    }
}
