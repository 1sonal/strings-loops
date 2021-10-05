using System;
using System.Text;

namespace ConsoleApp3
{
    class Reverse
    {
        static void Main(string[] args)
        {
            String str = "hi welcome to verve square";
                String s1 = "";
              for (int i = str.Length - 1; i >= 0; i--)
              {
                  s1 = s1 + str[i];
              }
            
           
            Console.WriteLine("Reversed string is:" + s1);
            Console.ReadLine();
        }
    }
}
