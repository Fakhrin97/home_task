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
            while (true)
            {
                Console.WriteLine("Enter one Number");
                int randomCaount = Convert.ToInt32(Console.ReadLine());

                if (randomCaount % 7 != 0)
                {
                    int remainder = randomCaount % 7;
                    if (remainder < 4)
                    {
                        Console.WriteLine("The most closest value ");
                        Console.WriteLine(randomCaount - remainder +"\n");
                    }

                    else
                    {
                        Console.WriteLine("The most closest value ");
                        Console.WriteLine(7 - remainder + randomCaount + "\n");
                    }
                }

                else
                {
                    Console.WriteLine("This numer divide by 7 \n ");
                }

            }
        }
    }
}
