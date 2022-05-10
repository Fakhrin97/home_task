using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Word : IPrintable
    {
       

        

        void IPrintable.Print()
        {
            Console.WriteLine("Print Word Format");
        }
    }
}
