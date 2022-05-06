using System;

namespace MainPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Print Pdf");
            Console.WriteLine("2.Print Excel");
            Console.WriteLine("3.Print Word");
            byte selection = Convert.ToByte(Console.ReadLine());
            if (selection==1)
            {
                MainPrintFile mainPrintFile = new Pdf("Print Pdf");
                mainPrintFile.PrintFile();
            }
            else if (selection==2)
            {
                MainPrintFile mainPrintExcel = new Excel("Print Excel");
                mainPrintExcel.PrintFile();
            }
            else if (selection==3)
            {
                MainPrintFile mainPrintWord = new Word("Print Word");
                mainPrintWord.PrintFile();
            }
            

            

            


        }
    }
}
