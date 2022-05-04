namespace MilkSell
{
    internal class Milk : Product
    {
        public byte Volume;
        public static string FatRate;
        public Milk(string name, byte count) : base(name, count)
        {
            Volume = count;

        }
        public override void Sell()
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
        static Milk()
        {
            FatRate = "3 %";
        }
    }
}
