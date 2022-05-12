using System;
using System.Collections.Generic;
using System.Text;

namespace FindAllByPopulation
{
    internal class City
    {
        public string Name { get; set; }    
        public int Population { get; set; }
        public City( int papulation, string name)
        {
            
            Population = papulation;
            Name = name;
        }
        public override string ToString()
        {
            return $"City:{Name} - Population:{Population}";
        }
    }
}
