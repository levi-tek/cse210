using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 104;
        while (guess != number)
        {
            Console.Write("What is your guess?: ");
            string guessed = Console.ReadLine();
            guess = int.Parse(guessed);
            if (number == guess)
            {
                Console.WriteLine("You guessed it! ");
            }
            else if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lesser");
            }
        }
        Console.Write("Do you want to play again?: ");
        string yes = Console.ReadLine();
        while (yes == "yes")
        {
            randomGenerator = new Random();
            number = randomGenerator.Next(1, 101);

            guess = 104;
            while (guess != number)
            {
                Console.Write("What is your guess?: ");
                string guessed = Console.ReadLine();
                guess = int.Parse(guessed);
                if (number == guess)
                {
                    Console.WriteLine("You guessed it! ");
                }
                else if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else 
                {
                    Console.WriteLine("Lesser");
                }
            }
        }


    }
}