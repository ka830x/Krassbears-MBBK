using System.Security.Cryptography;
using System.Transactions;

namespace zahlen_raten;

class Program
{
    static void Main(string[] args)
    {
        int target = new Random().Next(1, 12);
        int guess = 0;

        while (guess != target) 
        { 
                Console.WriteLine("enter Guess:");
                guess = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine(target);
        Console.WriteLine(guess);
    }
}