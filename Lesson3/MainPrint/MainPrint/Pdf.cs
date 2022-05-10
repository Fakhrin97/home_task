using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Pdf : IPrintable
    {
        
         

        void IPrintable.Print()
        {
            Console.WriteLine("Print Pdf Format");
        }
    }
}
