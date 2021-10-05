using System;
using System.Text;

namespace StringProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder s1 = new StringBuilder("Today is a great day !!");
            Console.WriteLine(s1);
            Console.WriteLine(s1.Length);
            Console.WriteLine(s1.Capacity);
            String s2 = s1.ToString();
            Console.WriteLine(s2);

            StringBuilder sb1 = new StringBuilder("abc");
            StringBuilder sb2 = new StringBuilder("abc", 16);
            Console.WriteLine("sb1.Length = {0}, sb1.Capacity = {1}", sb1.Length, sb1.Capacity);
            Console.WriteLine("sb1.Length = {0}, sb1.Capacity = {1}", sb2.Length, sb1.Capacity);

            Console.ReadLine();
        }
    }
}
