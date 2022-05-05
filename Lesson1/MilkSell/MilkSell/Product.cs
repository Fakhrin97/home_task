namespace MilkSell
{
    public abstract class Product
    {
        public string Name;
        public static byte Price;
        public byte Count;
        public int Totalincome;
        public static int Income;

        public Product(string name, byte count)
        {
            Name = name;
            Count = count;
            Totalincome = count * Price;
        }

        static Product()
        {
            Price = 3;
            Income = 0;
        }

        public abstract void Sell();       


    }
}
