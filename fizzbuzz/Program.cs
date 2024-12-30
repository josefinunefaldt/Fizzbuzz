using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        if (args.Contains("--sort"))
        {
            args = args.OrderBy(x => x).ToArray();
        }
        foreach (var arg in args)
        {
            if (string.IsNullOrEmpty(arg) || arg == "--sort")
            {
                continue;
            }
            if (arg.Contains('-'))
            {
                var rangeParts = arg.Split('-');
                if (rangeParts.Length == 2 && int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                {
                    for (int i = start; i <= end; i++)
                    {
                        string result = FizzBuzz(i);
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid range");
                }
            }


            else if (int.TryParse(arg, out int number))
            {
                string result = FizzBuzz(number);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Invalid input");
            }
        }
    }

    static string FizzBuzz(int num)
    {
        if (num % 3 == 0 && num % 5 == 0)
            return "FizzBuzz";
        else if (num % 3 == 0)
            return "Fizz";
        else if (num % 5 == 0)
            return "Buzz";
        else
            return num.ToString();
    }
}
