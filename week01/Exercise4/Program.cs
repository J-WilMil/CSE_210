using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int high = 0;
        int number = 1;
        int low = 999999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            
            if (number != 0)
            {numbers.Add(number);}
        }

        // sum

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
        }
        
        Console.WriteLine($"Total sum is: {sum}");

        // ave

        int ave = sum / numbers.Count;
        Console.WriteLine($"Average is: {ave}");

        // largest

        for (int i = 0; i < numbers.Count; i++)
        {
            if (high < numbers[i])
            {
                high = numbers[i];
            }
        }

        // smallest pos num

        for (int i = 0; i < numbers.Count; i++)
        {
            if (low > numbers[i] && 0 < numbers[i])
            {
                low = numbers[i];
            }
        }

        Console.WriteLine($"Highest number is: {high}");
        Console.WriteLine($"Lowest pos number is: {low}");

        numbers.Sort();

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}