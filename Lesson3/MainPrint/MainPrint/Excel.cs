using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Excel : IPrintable
    {
        
        
        void IPrintable.Print()
        {
            Console.WriteLine("Print Excel Format");
        }
    }
}
