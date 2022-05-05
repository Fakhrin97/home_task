using System;

namespace CarModle
{
    public abstract class Vehicle
    {
        public string Brend;
        public string Model;
        public string Color;
        public short MaxSpeed;
        public Vehicle()
        {
            Console.WriteLine("Car Created");
        }
        public Vehicle(string brend, string model) : this()
        {
            if (!string.IsNullOrEmpty(brend) && !string.IsNullOrEmpty(model))
            {
                Brend = brend;
                Model = model;
            }
            
        }
        public Vehicle(string brend, string model, string color, short maxspeed) : this(brend, model)
        {
            if (Brend != null && Model != null)
            {
                Color = color;
                MaxSpeed = maxspeed;
            }            
        }
        public abstract string getInformation();
        

    }
    
}
