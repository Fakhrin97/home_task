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

        public void Sell()
        {

            if (Count > 0)
            {
                Income += Price;
                System.Console.WriteLine($"Income:{Income} Azn.Qalan Mehsulun Sayi {Count - 1} ededir.");
                System.Console.WriteLine();
                Count--;
            }
            else
            {
                System.Console.WriteLine($"Mehsul artiq Bitib.Umumi Gelir:{Totalincome} Azn");
                System.Console.WriteLine();
            }

        }


    }
}
