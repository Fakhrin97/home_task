namespace CarModle
{
    internal class Bus : Vehicle
    {
        public byte PassengerCount;
        public Bus(string brend, string model, string color, short maxspeed,byte passengercount) : base(brend, model, color, maxspeed)
        {
            PassengerCount = passengercount;
        }

        public override string getInformation()
        {
            if (Brend == null && Model == null)
            {
               return "Bu method yardila bilmez";
            }
            else
            {
                return ($"Brend:{Brend} Model:{Model} Color:{Color} Max Speed:{MaxSpeed} Passenger Count:{PassengerCount} ");
            }
           

        }
    }
}
