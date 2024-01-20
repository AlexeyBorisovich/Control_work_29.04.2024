using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        double average = CalculateAverage(numbers);

        Console.WriteLine("Среднее арифметическое: " + average);

        Console.ReadKey();
    }
    static double CalculateAverage(int[] array)
    {
        if (array.Length == 0)
            return 0;

        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}