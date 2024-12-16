

class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        int Sum;
        program.Add(15,20,out Sum);

        Console.WriteLine($"Sum = {Sum}");
    }

    public void Add(float FN, int SN, int TN)
    {
        Console.WriteLine("Sum = {Sum}", FN + SN);
    }

    public void Add(int FN, int SN, out int Sum)
    {
        Sum = FN + SN;
        Console.WriteLine($"Sum = {Sum}", FN + SN);      
    }

    //public void Add(int FN, int SN)
    //{
    //    Console.WriteLine("Sum = {Sum}", FN + SN);
    //}

    //public void Add(float FN, int SN)
    //{
    //    Console.WriteLine("Sum = {Sum}", FN + SN);
    //}

    //public void Add(int FN, float SN)
    //{
    //    Console.WriteLine("Sum = {Sum}", FN + SN);
    //}

    //public void Add(float FN, float SN)
    //{
    //    Console.WriteLine("Sum = {Sum}", FN + SN);
    //}
}