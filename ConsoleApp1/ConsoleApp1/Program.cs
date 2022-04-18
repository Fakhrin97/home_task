using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ededlerden ibaret array verilib, bu ededlerin en boyuyunu tapmali.
            //Mes: [10,8,49,17,5] Ekrana en boyuk eded yazilmalidir: 49
            Console.WriteLine("Determine the size of the array");
            int size=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array's Elements:");
            int[] arry = new int[size];
            SearchMaxElement(arry , size);
            

        }
        public static void SearchMaxElement (int [] arry , int size)
        {
            int maxElement = arry[0];

            for (int i = 0; i < size; i++)
            {
                arry[i] = Convert.ToInt32(Console.ReadLine());
                if (arry[i] > maxElement)
                {
                    maxElement = arry[i];

                }
            }

            Console.WriteLine("Max element is:" + maxElement);
        }
    }
}
