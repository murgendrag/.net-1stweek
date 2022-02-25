using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapyear
{
    public class powerof2
    {
        public static void tableofpowerof2()
        {
            Console.WriteLine("table of power of 2");
            Console.WriteLine("enter value of n for table");
            int n = Convert.ToInt32(Console.ReadLine());
            int pow = 1;

            if (n <= 31) 
            {
                for (int i = 0; i <n; i++) 
                {
                    pow = pow * 2;
                  //  int power = 1;
                   //// for (int j = 1; j <= i; j++) 

                   // {
                   //     power = power * 2;
                     //   Console.WriteLine("2^" + j +"="+ power);
                  //  }
                }
                Console.WriteLine("2^" +pow);

                
            }
        }
    }
}
