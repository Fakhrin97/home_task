using System;

namespace MainPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("1.Print Pdf");
            Console.WriteLine("2.Print Word");
            Console.WriteLine("3.Print Excel");
            byte selection = Convert.ToByte(Console.ReadLine());
            if (selection == 1)
            {
                Print(new Pdf());
            }
            else if (selection == 2)
            {
                Print(new Word());
            }
            else if (selection == 3)
            {
                Print(new Excel());
            }

        }
        public static void Print(MainPrintFile MainPrint)
        {
            if (MainPrint is IPrintable)
            {
                IPrintable printable = (IPrintable)MainPrint;
                MainPrint.PrintFile(printable);
            }
        }

    }
}

