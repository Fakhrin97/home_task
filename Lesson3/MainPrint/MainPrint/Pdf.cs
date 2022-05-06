using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Pdf : MainPrintFile
    {
        public Pdf(string file) : base(file)
        {
        }

        public override void PrintFile()
        {
            Console.WriteLine(File);
        }
    }
}
