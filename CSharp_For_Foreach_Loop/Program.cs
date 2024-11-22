
class Program
{
    static void Main()
    {
        //Console.WriteLine("Welcome to Csharp");

        //int[] Numbers = new int[3];

        //Numbers[0] = 101;
        //Numbers[1] = 102;
        //Numbers[2] = 103;

        //foreach(int k in Numbers)
        //{
        //    Console.WriteLine(k);
        //}

        //for (int j = 0; j < Numbers.Length; j++)
        //{
        //    Console.WriteLine(Numbers[j]);
        //}

        //int i = 0;

        //while (i < Numbers.Length)
        //{
        //    Console.WriteLine(Numbers[i]);
        //    i++;
        //}

        //for (int i = 1; i <= 20; i++)
        //{
        //    Console.WriteLine(i);
        //    if(i == 10)
        //        break;
        //}

        //for (int i = 0; i <= 20; i=i+2)
        //{
        //    Console.WriteLine(i);
        //    if (i == 10)
        //        break;
        //}

        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 1)
                continue;
            Console.WriteLine(i);
        }
    }
}