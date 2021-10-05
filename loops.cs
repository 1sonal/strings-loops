using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing 1 to 10 except 5 using for loop
            for(int i=1;i<11;i++)
            {
                if (i == 5)
                    continue;
                else
                    Console.Write(i + "\t");
            }

            Console.WriteLine();
            //printing 1 to 10 except 5 using while loop
            int j = 0;
            while(j<=9) 
            {
                ++j;
                if (j == 5)
                    continue;
                else
                    Console.Write(j + "\t");
            }

            Console.WriteLine();
            //printing 1 to 10 except 5 using do-while loop
            int k = 0;
            do
            {
                ++k;
                if (k == 5)
                    continue;
                else
                    Console.Write(k + "\t");
            } while (k < 10);


            Console.ReadLine();
        }
    }
}
