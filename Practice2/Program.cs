using System;
using System.Diagnostics.Metrics;

namespace Practice2
{
    internal class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! From The Other Side");
           // First Pu
        }

        static void Test(char[] input)
        {
            int count = 1;
            int i = 0;
            for(int j = 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    count++;
                }
                else
                {
                   input[i] = count.ToString()[0];
                   count = 1;
                    i++;
                }
  
            }
            Console.WriteLine(input);
        }
    }
}
