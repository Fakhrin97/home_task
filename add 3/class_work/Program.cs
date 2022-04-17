using System;

namespace class_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Natural ededin evveline 3 kecirib yeni eded duzelden bir method yazin          Example: 529 => 3529
            //"3" + 529 => qadagandir
            Console.Write("Enter one Number:");
            int number =Convert.ToInt32(Console.ReadLine());
            newNum(number);

        }
        public static void newNum(int number)
        {
            int count = 0;
            int clone = number;
            
            while (clone>0)
            {
                clone /= 10;
                count++;

                
            }
            int rank = 1;
            for (int i = 0; i < count; i++)
            {
                rank = rank * 10;
            }
            int newNumber = 3 * rank + number;
            Console.WriteLine("New number:" + newNumber);
        }
        
        
                

                
                                  
    }
}
