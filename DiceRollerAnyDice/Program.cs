using System.Runtime.InteropServices;

class Program
{
    //Program runs until exited.

    static Random die = new Random();
    static void Main(string[] args)

    {
        int a = -1;
        while (a != 0){
            Console.WriteLine("Let's roll some dice! How many sides do the dice you want to roll have? Enter 0 to exit.");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many dice do you want to roll?");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DiceRoller(a, b) + " is your total from those dice!");
           }
        Console.WriteLine("Goodbye!");
    }

    static int DiceRoller(int x, int y)
    {
        int dsum = 0;
        for (int i = 1; i <= y; i++)
        {
            int a = die.Next(1, (x+1));
            dsum = dsum + a;
        }
        return dsum;
    }


}
