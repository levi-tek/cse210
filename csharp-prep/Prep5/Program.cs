using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int squareroot = SquareNumber(number);
        DisplayResult(username, squareroot);
        

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number:  ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        return number;
    }
    static int SquareNumber(int number)
    {
       int num = number * number;
       return num;
    }
    static void DisplayResult(string username, int squareroot )
    {
        Console.WriteLine($"{username}, the square of your number is {squareroot}");

    }

}