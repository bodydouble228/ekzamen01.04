using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;
        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Простые числа от 2 до 100:");
        for (int i = 2; i <= 100; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine(); 
    }
}
