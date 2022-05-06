using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Excel : MainPrintFile
    {
        public Excel(string file) : base(file)
        {
        }

        public override void PrintFile()
        {
            Console.WriteLine(File);
        }
    }
}
