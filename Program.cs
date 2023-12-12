using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Luvut välillä 1-99, jotka ovat jaollisia kolmella:");

        for (int i = 1; i <= 99; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}