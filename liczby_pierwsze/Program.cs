using System;
using System.Reflection.Metadata;


internal class Program
{

    public static void sito(bool[]tablica_liczb, int n)
    {
        for(int i = 0; i <= 100; i++)
        {
            tablica_liczb[i] = true;
        }

        int j = 2;

        for(int i = 2; i<=Math.Sqrt(n);i++)
        {
            if (tablica_liczb[i] == true)
            {
                for(j = i*i; j<=n;j=j+i)
                {
                    tablica_liczb[j] = false;
                }
            }

        }

        

    }

    private static void Main(string[] args)
    {
        bool []A = new bool[101];

        sito(A, 100);

        for (int i = 2; i <=100; i++)
        {
            if (A[i] == true)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("Hello, World!");
    }
}

