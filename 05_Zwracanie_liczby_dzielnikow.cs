using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę naturalną większą od 5: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int primeDivisors = CountPrimeDivisors(number);
        Console.WriteLine($"Liczba dzielników będących liczbami pierwszymi: {primeDivisors}");
    }

    static int CountPrimeDivisors(int number)
    {
        if (number <= 5)
        {
            return 0;
        }

        int count = 0;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                if (IsPrime(i))
                {
                    count++;
                }

                int otherDivisor = number / i;
                if (otherDivisor != i && IsPrime(otherDivisor))
                {
                    count++;
                }
            }
        }

        return count;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
