using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 10;
            array[2] = 100;
            array[3] = 1000;
            array[4] = 10000;
            

            Console.WriteLine(array.Rank);
            Console.WriteLine(array.Length);
            
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);



        }
    }
}
