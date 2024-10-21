using System;

class Program
{
    public static string score;
    public static int score1;
    public static void Main(string[] args)
    {
        AskNumber();
        GiveScore();
    }

    public static void AskNumber()
    {
        Console.WriteLine("Enter the number score you have in this class (0-100):");
        score = Console.ReadLine();
        score1 = int.Parse(score);
    }

    public static void GiveScore()
    {
        if (score1 >= 100){
            Console.WriteLine("Wow! 100... That's impressive!");
            Console.WriteLine("Letter Grade: A+");
        } else if (score1 >= 90) {
            Console.WriteLine("Very nice!");
            Console.WriteLine("Letter Grade: A");
        } else if (score1 >= 80) {
            Console.WriteLine("Keep it up!");
            Console.WriteLine("Letter Grade: B");
        } else if (score1 >= 70) {
            Console.WriteLine("You got this, keep working!");
            Console.WriteLine("Letter Grade: C");
        } else if (score1 >= 60) {
            Console.WriteLine("Keep trying!");
            Console.WriteLine("Letter Grade: D");
        } else {
            Console.WriteLine("Don't give up!");
            Console.WriteLine("Letter Grade: F");
        }
    }
}