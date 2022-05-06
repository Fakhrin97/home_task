using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Pdf : MainPrintFile,IPrintable
    {
        

        public override void PrintFile(IPrintable printable)
        {
            printable.Print();
        }             

        void IPrintable.Print()
        {
            Console.WriteLine("Print Pdf Format");
        }
    }
}
