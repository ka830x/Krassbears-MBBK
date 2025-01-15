namespace while_loop_aufgabe3;

class Program
{
    static void Main(string[] args)
    {
        int summe = 0;
        int i = 10;
        while(i > 0)
        {
            summe = summe + i;
            i--;
        }
        Console.WriteLine("Summe: " + summe);
    }
}