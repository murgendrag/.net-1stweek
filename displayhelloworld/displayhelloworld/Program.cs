using System;

namespace displayhelloworld
{
    class program
    {

        static void Main (string[] args)
        {
            int num = 4;
            float num1 = 4.00f;
            double num2 = 4.987678;
            char num3 = 'g';
            bool num4 = false;
            string num5 = "murgendra";

            Console.WriteLine("the integer num is:"+num);
            Console.WriteLine("the float num is :" + num1);
            Console.WriteLine("the double num is:" + num2);
            Console.WriteLine("the char valueis:" + num3);
            Console.WriteLine("the bool value is:" + num4);
            Console.WriteLine("the string value is:" + num5);

            Console.WriteLine("enter the value");
            int input =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The value is"+ input);
            Console.WriteLine("hello world");
        
        }
            
     }

}