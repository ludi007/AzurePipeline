using System;

namespace AzurePipeline
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter int number:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You entered :{0}", number);
            Console.ReadLine();
        }
    }
}
