using System;

    class floyd
{
    static void Main()
    {
        Console.WriteLine("enter no :");
        int a;

        if(!int.TryParse(Console.ReadLine(), out a)||a<0) {
            Console.WriteLine("enter valid int");
            return;
        }

        int num = 1;
        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }

    }
}