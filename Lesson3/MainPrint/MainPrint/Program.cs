﻿using System;

namespace MainPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Print Pdf");
            Console.WriteLine("2.Print Word");
            Console.WriteLine("3.Print Excel");
            byte selection = Convert.ToByte(Console.ReadLine());
            if (selection==1)
            {
                MainPrintFile mainprintformat = new Pdf();
                IPrintable printable = (IPrintable)mainprintformat;
                mainprintformat.PrintFile(printable);                   
            }
            else if (selection == 2)
            {
                MainPrintFile mainprintformat = new Word();
                IPrintable printable = (IPrintable)mainprintformat;
                mainprintformat.PrintFile(printable);
                
            }
            else if (selection == 3)
            {
                MainPrintFile mainprintformat = new Excel();
                IPrintable printable = (IPrintable)mainprintformat;
                mainprintformat.PrintFile(printable);
            }







        }
    }
}
