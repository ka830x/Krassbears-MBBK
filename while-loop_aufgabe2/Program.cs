namespace while_loop_aufgabe2;

class Program
{
    static void Main(string[] args)
    {
        string output = null;
        int i = 0;
        while (i < 10)
        {
            i++;
            output += i.ToString() + " ";
        }
        Console.WriteLine(output);
    }
}