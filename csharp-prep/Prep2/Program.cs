using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string grades = Console.ReadLine();
        int grade = int.Parse(grades);
        string letter;
        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine(letter);
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else if (grade < 70)
        {
            Console.WriteLine("So sorry! You failed the course, but dont worry you can still do beter next time");
        }
    }
}