using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal  class MainPrintFile
    {

        public MainPrintFile(IPrintable print)
        {
            print.Print();
        }
    }
}
