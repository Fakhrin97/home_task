using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 eded daxil edin. Eger o eded 50den kicikdirse o edede qeder 3-e bolunen,
            // 50-100 araligindadirsa o edede qeder 5e bolunen,
            // 100den boyukdurse o edede qeder 8 e bolunen ededleri ayri bir arrayin icerisine elave edib,
            // bolunen butun ededleri ekrana cixardan bir alqoritm
            int randomNumber=Convert.ToInt32(Console.ReadLine());
            if (randomNumber<50)
            {
                for (int i = 0; i < randomNumber; i++)
                {
                    if (i%3==0)
                    {
                        Console.Write(i + " ");

                    }
                }
            }
            if (randomNumber >= 50 &&randomNumber<=100)
            {
                for (int i = 0; i < randomNumber; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.Write(i + " ");

                    }
                }
            }
            if(randomNumber>100)
            {
                for (int i = 0; i < randomNumber; i++)
                {
                    if (i % 8 == 0)
                    {
                        Console.Write(i + " ");

                    }
                }
            }
            
        }
    }
}
