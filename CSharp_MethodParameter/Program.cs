
class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello");

        //int i = 0;

        //SimpleMethod(ref i);

        //Console.WriteLine(i);

        //int Total = 0;
        //int Product = 1;

        //Calculate(10,20, out Total, out Product);

        //Console.WriteLine("Sum = {0} && Product = {1}",Total,Product);

        int[] Numbers = new int[3];

        Numbers[0] = 1;
        Numbers[1] = 2;
        Numbers[2] = 3;

        //ParamsMethod(Numbers);
        //ParamsMethod();

        ParamsMethod(1,2,3,4,5);
    }

    //params array should be the last one in method parameter
    public static void ParamsMethod(params int[] Numbers)
    {
        Console.WriteLine("There are {0} elements", Numbers.Length);
    }
    
    public static void Calculate (int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }
    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
}