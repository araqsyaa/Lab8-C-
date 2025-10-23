using System;

class InvalidGradeException : Exception
{
    public InvalidGradeException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter student grade (0–100): ");
            int grade = int.Parse(Console.ReadLine());
            CheckGrade(grade);
            Console.WriteLine("Grade is valid.");
        }
        catch (InvalidGradeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CheckGrade(int grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new InvalidGradeException("Grade must be between 0 and 100.");
        }
    }
}
