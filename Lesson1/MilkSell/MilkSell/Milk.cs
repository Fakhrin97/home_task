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
        static Milk()
        {
            FatRate = "3 %";
        }
    }
}
