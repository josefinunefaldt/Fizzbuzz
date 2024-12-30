class Program
{
    static void Main(string[] args)
    {

        foreach (var arg in args)
        {

            if (string.IsNullOrEmpty(arg) || arg.Contains("--sort"))
            {
                args = [.. args.OrderBy(x => x)];
                continue;
            }
            if (int.TryParse(arg, out int number))
            {

                string result = FizzBuzz(number);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"Invalid input: '{arg}'");
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
