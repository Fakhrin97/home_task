using System;

namespace CarModle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter car's Brend:");
            string brend = Console.ReadLine();

            Console.Write("Enter car's Model:");
            string model = Console.ReadLine();

            Console.Write("Enter car's Color:");
            string color = Console.ReadLine();

            bool resalt = false;
            short maxspeed=0;
            while (!resalt)
            {
                Console.Write("Enter Max Speed:");
                resalt = short.TryParse(Console.ReadLine(), out maxspeed);
                if (resalt == false) Console.WriteLine("Enter Correct Variant");             
                
            }

            resalt = false;
            byte pasenger = 0;

            while (!resalt)
            {                
                Console.Write("Enter Passenger Count:");
                resalt = byte.TryParse(Console.ReadLine(), out pasenger);
                if (resalt == false) Console.WriteLine("Enter Correct Variant");
            }

            Bus bus = new Bus(brend, model, color, maxspeed, pasenger);
            Console.WriteLine(bus.getInformation());

        }
    }
}
