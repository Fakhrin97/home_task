using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FindAllByPopulation
{
    internal class Caountry
    {
        public string Name { get; set; }    
       
        public ArrayList cityes;
        public Caountry(string name)
        {
            Name = name;
            cityes = new ArrayList();
            
        }
        public void Add(City city)
        {
            cityes.Add(city);   
        }
       
        public ArrayList get()
        {
            return cityes;  
        }
        public int totalPopulation()
        {
            int total = 0;
            foreach (City item in cityes)
            {
                total += item.Population;
            }
            return total;
        }
        public void FindAllByPopulation(int min, int max)
        {
            foreach (City item in cityes)
            {
                if (item.Population>min && item.Population<max)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
