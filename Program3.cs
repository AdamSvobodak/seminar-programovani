using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadejte číslo pro výpočet faktorálu: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double faktoral = 1;

        for (int i = 1; i <= n; i++)
        {
            faktoral *= i;
        }

        Console.WriteLine("faktoral čísla "+n+" je: "+faktoral);
    }
}