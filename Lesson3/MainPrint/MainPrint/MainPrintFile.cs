using System;
using System.Collections.Generic;
using System.Text;

namespace MainPrint
{
    internal abstract class MainPrintFile
    {
        public string File;
        public MainPrintFile(string file)
        {
            File = file;
        }
        public abstract void PrintFile();
    }
}
