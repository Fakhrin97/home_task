using System;

namespace MainPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainPrintFile mainPrintFile = new MainPrintFile(new Excel());
            MainPrintFile mainPrintFile1 = new MainPrintFile(new Pdf());
            MainPrintFile mainPrintFile2 = new MainPrintFile(new Word());


        }
      

    }
}

