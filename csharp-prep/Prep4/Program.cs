using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when you are done.");
        List<int> number = new List<int>();
        Console.Write("Enter number: ");
        string num = Console.ReadLine();
        int numbers = int.Parse(num);
        number.Add(numbers);
        while (num != "0")
        {
            Console.Write("Enter number: ");
            num = Console.ReadLine();
            numbers = int.Parse(num);
            number.Add(numbers);
        }
        int sum = number.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double average = number.Average();
        Console.WriteLine($"The average is: {average}");
        int max = number.Max();
        Console.WriteLine($"The largest number is: {max}");


        
        
    }
}