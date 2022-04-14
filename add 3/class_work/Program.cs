using System;

namespace class_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Natural ededin evveline 3 kecirib yeni eded duzelden bir method yazin          Example: 529 => 3529
            //"3" + 529 => qadagandir
            Console.WriteLine("Enter Number");
            int num =Convert.ToInt32(Console.ReadLine());
            newNum(num);

        }
        public static void newNum(int num)
        {
            int count = 0;
            int clone = num;
            
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
            int newnumber = 3 * rank + num;
            Console.WriteLine(newnumber);
        }
        
        
                

                
                                  
    }
}
