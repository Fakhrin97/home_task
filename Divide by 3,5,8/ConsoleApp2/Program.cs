using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 eded daxil edin. Eger o eded 50den kicikdirse o edede qeder 3-e bolunen,
            // 50-100 araligindadirsa o edede qeder 5e bolunen,
            // 100den boyukdurse o edede qeder 8 e bolunen ededleri ayri bir arrayin icerisine elave edib,
            // bolunen butun ededleri ekrana cixardan bir alqoritm

            Console.Write("Enret one number:");
            int randomNumber = Convert.ToInt32(Console.ReadLine());
            int size = 0;

            if (randomNumber < 50)
            {
                int add = 3;
                size = SizeOfArry(randomNumber, add, size);
                Console.WriteLine("The size of the array:" + size);
                CreatNewArry(size, add, 3);
            }
            if (randomNumber > 50 && randomNumber < 100)
            {
                int add = 5;
                size = SizeOfArry(randomNumber, add, size);
                Console.WriteLine("The size of the array:" + size);
                CreatNewArry(size, add, 5);

            }
            if (randomNumber > 100)
            {

                int add = 8;
                size = SizeOfArry(randomNumber, add, size);
                Console.WriteLine("The size of the array:" + size);
                CreatNewArry(size, add, 8);

            }


        }
        public static int SizeOfArry(int randomNumber, int add, int size)
        {

            for (int i = 1; i < randomNumber; i++)
            {
                if (i % add == 0)
                {
                    size++;

                }
            }
            return size;
        }
        public static void CreatNewArry(int size, int add, int num)
        {
            int[] aryy = new int[size];
            for (int i = 0; i < size; i++)
            {
                aryy[i] = add;
                add += num;
                Console.WriteLine(aryy[i]);

            }
        }

    
    }
}
