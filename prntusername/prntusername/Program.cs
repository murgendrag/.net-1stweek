
using System;

namespace prntusername
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("The length os string" + name.Length);

            if (name.Length >= 3)
            {
                Console.WriteLine("Hello" + name + ",How are you");
            }
            else
            {
                Console.WriteLine(" Enter minimum of 3 characters else statement");
            }
        }
    }
}