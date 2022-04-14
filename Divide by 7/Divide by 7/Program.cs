using System;

namespace Divide_by_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console app-da bir eded daxil olunur. Eger bu eded 7-ye bolunurse ekrana "7 ye bolunur" yazilsin.
            //Eks halda daxil olunan edede en yaxin 7-ye bolunen eded ekranda yazilsin
            //(Meselen: 17 yazilibsa ekrana  21 yox 14 cixsin, 19 yazilibsa 21 cixsin)
            int randomCaount = Convert.ToInt32(Console.ReadLine());
            if (randomCaount%7!=0)
            {
                int divide=randomCaount%7;
                if (divide<4)
                {
                    Console.WriteLine(randomCaount-divide);
                }
                else
                {
                    Console.WriteLine(7-divide+randomCaount);
                }
            }
            else
            {
                Console.WriteLine("This numer divide by 7");
            }

        }
    }
}
