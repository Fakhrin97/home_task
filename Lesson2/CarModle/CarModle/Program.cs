using System;

namespace CarModle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = createBus();
            Console.WriteLine(bus.getInformation());


        }
        public static Bus createBus()
        {
            bool resalt = false;
            string brend = "";
            while (!resalt)
            {
                Console.Write("Enter car's Brend:");
                brend = Console.ReadLine();
                if (string.IsNullOrEmpty(brend) || string.IsNullOrWhiteSpace(brend))
                {
                    Console.WriteLine("Brend olmadan class yaradila bilmez!");
                }
                else resalt = true;

            }
            resalt = false;

            string model = "";

            while (!resalt)
            {
                Console.Write("Enter car's Model:");
                model = Console.ReadLine();
                if (string.IsNullOrEmpty(model) || string.IsNullOrWhiteSpace(model))
                {
                    Console.WriteLine("Model olmadan class yaradila bilmez!");
                }
                else resalt = true;

            }

            resalt = false;

            Console.Write("Enter car's Color:");
            string color = Console.ReadLine();


            short maxspeed = 0;
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
            return bus;

        }
    }
}
