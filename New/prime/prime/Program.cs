using System;

class prime
{
    static void Main()
    {
        Console.Write("enter no : ");

        int num;
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("enter valid input");
            return;
        }
        bool isp = true;
        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isp = false;
            }
        }

        if (num < 2)
        {
            Console.WriteLine("not prime");
            return;
        }
        else if (isp)
        {
            Console.WriteLine(" is prime");
        }
        else
        {
            Console.WriteLine("not prime");
        }
    }
}
