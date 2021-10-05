using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with strings and numbers operations
            Console.WriteLine(4+3.07);
            Console.WriteLine("43" + "44.7");
            Console.WriteLine(2 - 7 * 5);
            Console.WriteLine(7 / 2);
            Console.WriteLine(7 % 2);
            Console.WriteLine(7 / 2.0);
            Console.WriteLine(7 % 2.0);
            int num = 7;
            float num1 = 2.0f;
            float ans = num % num1;
            Console.WriteLine(ans);
            int ans1 = (int)(num % num1);   //typecasting
            Console.WriteLine(ans1);

            float n1 = 7.0f;
            float n2 = 2.1f;
            float n3 = n1 % n2;  
            Console.WriteLine(n3);


            Console.ReadLine();
        }
    }
}
