using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n and k:");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose series (1, 2, or 3):");
        int choice = int.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = Series1(n, k);
                break;
            case 2:
                result = Series2(n, k);
                break;
            case 3:
                result = Series3(n, k);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }

    static double Series1(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / (n + i);
        }
        return sum;
    }

    static double Series2(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / (n * n + i * i);
        }
        return sum;
    }

    static double Series3(int n, int k)
    {
        double sum = 0;
        for (int i = 1; i <= k; i++)
        {
            sum += (double)i / ((n + i - 1) * (n + i));
        }
        return sum;
    }
}

