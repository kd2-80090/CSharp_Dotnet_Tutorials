
class Program
{
    static void Main()
    {
        //Console.WriteLine("Welcome");

        //Program program = new Program();

        //program.EvenNumbers();

        Program.EvenNumbers();

        Console.WriteLine();
        Program.EvenNumbers(20);

        Program p = new Program();

        int Sum = p.Add(1, 2);

        Console.WriteLine(Sum);
    }

    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers()
    {
        int Start = 2;

        while (Start <= 100)
        {
            Console.Write(Start + " ");

            Start = Start + 2;
        }
    }

    public static void EvenNumbers(int Target)
    {
        int Start = 2;

        while (Start <= Target)
        {
            Console.Write(Start + " ");

            Start = Start + 2;
        }
    }
}