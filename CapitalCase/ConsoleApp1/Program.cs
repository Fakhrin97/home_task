using System;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        private static readonly object stringBuilder;

        static void Main(string[] args)
        {

            Console.Write("Enter some words:");
            string word = Console.ReadLine();
            string LowerWord = word.ToLower();
            string [] arr = LowerWord.Split();

            for (int i = 0; i < arr.Length; i++)
            {
                string clone = arr[i];
                string newclone=clone.Substring(0,1).ToUpper()+clone.Substring(1);
                arr[i] = newclone;
                
            } 
             string UpperCase =string.Join(" ", arr);
             Console.WriteLine(UpperCase);   

            
            







        }
       
    }
}
