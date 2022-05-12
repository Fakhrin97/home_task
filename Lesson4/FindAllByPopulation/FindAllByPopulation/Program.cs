using System;

namespace FindAllByPopulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caountry caountryAzerbaycan = new Caountry("Azerbaycan");
            Console.WriteLine(caountryAzerbaycan.Name);
            City cityBaki = new City(2000000,"Baki");
            City cityGence = new City(1500000,"Gence");
            City citySumqayit = new City(1700000,"Sumqayit");
            City cityMingecevir = new City( 800000,"Mingecevir");
            City cityTevlax = new City(700000,"Yevlax");
            caountryAzerbaycan.Add(cityBaki);
            caountryAzerbaycan.Add(cityGence);
            caountryAzerbaycan.Add(citySumqayit);
            caountryAzerbaycan.Add(cityMingecevir);
            caountryAzerbaycan.Add(cityTevlax);
            
            foreach (var item in caountryAzerbaycan.get())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(caountryAzerbaycan.totalPopulation());
            Console.WriteLine("################################");
            Console.WriteLine("Ehalisi 1000000 dan cox olan shehereler");
            caountryAzerbaycan.FindAllByPopulation(1000000, 400000000);
            
            Console.WriteLine("################################");
            Caountry caountryRussia = new Caountry("Russia");
            Console.WriteLine(caountryRussia.Name);
            City cityMaskva = new City( 17125000,"Maskva");
            City citySaintPetersburg = new City( 5351935,"Saint Petersburg");
            City citySamara = new City( 1169719,"Samara");
            City cityNovosibirsk = new City( 1602915,"Novosibirsk");
            City cityKazan = new City(1243500,"Kazan");
            caountryRussia.Add(cityMaskva);
            caountryRussia.Add(citySaintPetersburg);
            caountryRussia.Add(citySamara);
            caountryRussia.Add(cityNovosibirsk);
            caountryRussia.Add(cityKazan);
            foreach (var item in caountryRussia.get())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(caountryRussia.totalPopulation());
            Console.WriteLine("################################");
            Console.WriteLine("Ehalisi 1000000 dan 15000000 e dek olan shehereler");
            caountryRussia.FindAllByPopulation(1002914, 15125001);
            




        }
    }
}
