// See https://aka.ms/new-console-template for more information
using System;

class fibona
{
    static void Main()
    {
        int a;
        Console.Write("enter no");

        if(!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("input incorect");
            return;
        }
        

        int t, f = 0, s = 1;

        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(f);
            t = f + s;
            f = s;
            s = t;
        }
    }
}
