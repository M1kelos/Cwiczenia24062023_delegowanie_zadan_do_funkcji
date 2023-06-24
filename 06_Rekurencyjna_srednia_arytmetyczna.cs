using System;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = { 2.5, 3.8, 1.2, 4.6, 2.1 };
        int size = numbers.Length;

        double average = CalculateRecursiveAverage(numbers, size);
        Console.WriteLine($"Średnia arytmetyczna: {average}");
    }

    static double CalculateRecursiveAverage(double[] numbers, int size)
    {
        if (size == 0)
        {
            return 0.0;
        }

        double sum = numbers[size - 1] + CalculateRecursiveAverage(numbers, size - 1);
        double average = sum / size;
        return average;
    }
}
