using System.Diagnostics;

Console.WriteLine("Please write 3 integers in the following format: '1 2 3'");
int[]? numbers = ValidateInput(Console.ReadLine());
if (numbers != null)
{
    for (int i = 1; i <= numbers[2] ; i++)
    {
        if (i % numbers[0] == 0 && i % numbers[1] == 0)
        {
            Console.WriteLine("FizzBuzz");
        } else if (i % numbers[0] == 0)
        {
            Console.WriteLine("Fizz");
        } else if (i % numbers[1] == 0)
        {
            Console.WriteLine("Buzz");
        } else
        {
            Console.WriteLine(i);
        }
    }
}

//Takes a string and checks that it follows the correct format. If it does, returns an array of numbers. 
int[]? ValidateInput(string? input)
{
    if (input != null)
    {
        string[] parts = input.Split(" ");
        if (parts.Length == 3)
        {
            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(parts[i], out int number))
                {
                    numbers[i] = number;
                } else
                {
                    Console.WriteLine("Please only include integers");
                    return null;
                }
            } 
            return numbers;
        } else
        {
            Console.WriteLine("Please only include 3 values separated by a single space.");
            return null;
        }
    }
    return null;
}