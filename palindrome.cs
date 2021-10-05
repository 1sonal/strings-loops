using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
			//String str1 = "Dot saw I was tod";
			String str1 = Console.ReadLine();
			String str2 = str1.ToLower();
			String reverse = "";
			Console.WriteLine("reverse is:");
			for (int i = str2.Length - 1; i >= 0; i--)
			{
				reverse = reverse + str2[i];

			}
			Console.Write(reverse);
			Console.WriteLine();
			if (str2.Contains(reverse))
			{
				Console.WriteLine("String is palindrome");
			}
			else
				Console.WriteLine("String is not a palindrome");


				
			Console.ReadLine();
        }
    }
}
