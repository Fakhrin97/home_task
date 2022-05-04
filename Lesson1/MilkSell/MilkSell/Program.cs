using System;

namespace MilkSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mehsulun Adini Qeyd Edin:");
            string name=Console.ReadLine();
            Console.WriteLine();

            Console.Write("Mehsulun Sayini Qeyd Edin:");
            byte count = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
                      
            Milk milk = new Milk(name, count);
            
            bool resalt = false;

            while (!resalt)
            {
                Console.WriteLine("1.Mehsulu Sat.");
                Console.WriteLine("0.Proqrami bagla.");
                Console.WriteLine();

                Console.Write("Select:");
                string selectNum = Console.ReadLine();
                int num;
                resalt = int.TryParse(selectNum, out num);

                if (resalt == false) Console.WriteLine("Enter Correct Format");
                else
                {
                    resalt = false;
                    Console.WriteLine();

                    if (num == 1)
                    {
                        milk.Sell();
                    }
                    else if (num == 0) resalt = true;
                }
            }



        }
    }
}
