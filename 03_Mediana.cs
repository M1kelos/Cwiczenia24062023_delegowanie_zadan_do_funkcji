using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 7, 3, 1, 4, 6 };
        int size = numbers.Length;

        int median = CalculateMedian(numbers, size);
        Console.WriteLine($"Mediana: {median}");
    }

    static int CalculateMedian(int[] numbers, int size)
    {
        if (size == 0)
        {
            throw new ArgumentException("Tablica jest pusta.");
        }

        Array.Sort(numbers);

        int middleIndex = size / 2;

        if (size % 2 == 0)
        {
            // Parzysta liczba elementów - średnia dwóch środkowych liczb
            int median1 = numbers[middleIndex - 1];
            int median2 = numbers[middleIndex];
            return (median1 + median2) / 2;
        }
        else
        {
            // Nieparzysta liczba elementów - środkowa liczba
            return numbers[middleIndex];
        }
    }
}