using MagazineChek.Models;
using System;


internal class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        int selection;
        int count = 0;

        do
        {

            Product product = new Product("Alma", 10);
            Product product1 = new Product("Armud", 15);
            Product product2 = new Product("Alca", 20);
            Product product3 = new Product("Erik", 30);

            Console.WriteLine("1.Alma Price:10");
            Console.WriteLine("2.Armud Price:15");
            Console.WriteLine("3.Alca Price:20");
            Console.WriteLine("4.Erik Price:30");
            Console.WriteLine("0.Total Price");

            Console.Write("Add a Basket:");
            selection = int.Parse(Console.ReadLine());

            if (selection != 0)
            {
                Console.Write("How Many:");
                count = int.Parse(Console.ReadLine());

            }

            switch (selection)
            {
                case 1:
                    order.Add(product, count);
                    break;
                case 2:
                    order.Add(product1, count);
                    break;
                case 3:
                    order.Add(product2, count);
                    break;
                case 4:
                    order.Add(product3, count);
                    break;
                default:
                    break;
            }

            Console.Clear();

        } while (selection != 0);


        foreach (var item in order.Get())
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Total Price:{order.TotalPrice()}");

        Predicate<Order> predicate = totalPrice =>
         {
             return order.TotalPrice() < 100;
         };

        Predicate<Order> predicate1 = totalPrice =>
        {
            return order.TotalPrice() > 200;
        };

        if (predicate(order))
        {
            Console.WriteLine("Buy less than 100 manats, you don't get discount");
        }
        else if (predicate1(order))
        {
            Console.WriteLine("Buy more than 200 manats, you get a 20% discount");
            Console.WriteLine($"Discounted price:{order.TotalPrice() * 0.8}");
        }
        else
        {
            Console.WriteLine("You get a 10% discount");
            Console.WriteLine($"Discounted price:{order.TotalPrice() * 0.9}");
        }




    }
}

