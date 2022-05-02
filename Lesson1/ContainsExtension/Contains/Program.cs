using System;

namespace Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Sentence:");
                string word = Console.ReadLine();
                Console.Write("Enter Search Word:");
                string searchword = Console.ReadLine();
                word.costomContains(searchword);
            }
                                       
        }
    }
}
