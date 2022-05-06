using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal class Word : MainPrintFile
    {
        public Word(string file) : base(file)
        {
        }

        public override void PrintFile()
        {
            Console.WriteLine(File);
        }

    }
}
