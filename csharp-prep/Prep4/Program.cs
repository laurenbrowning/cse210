using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        while (number != 0)
        {
            Console.WriteLine("Enter a number! when you want to stop enter 0");
            string answer = Console.ReadLine();
            number = int.Parse(answer);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The total is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The Average is: {average}");

        int biggest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > biggest)
            {
                biggest = num;
            }
        }
        Console.WriteLine($"The biggest is: {biggest}");
    }
}  