using System;
using System.Runtime.InteropServices;

    class Program
{         
    static void Main(string[] args)
    {
        // Goal: Display 50th value of Fib Sequence (0 is the first value!)
        // Fibonacci: Start at 0 and 1, sum 1, then 1+1 = 3

        double n1 = 0;
        double n2 = 1;
        double n3 = 0;

        Console.WriteLine("The 50th Number in a Fibonacci Sequence is: ");

        for(int i = 0; i < 49; i++)
        {
            n3 = n1 + n2; 
            n1 = n2;
            n2 = n3;
        }
        Console.WriteLine("{0}", n3);
        Console.ReadKey();
    }
}