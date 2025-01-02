
/// C# - Generics
/// 

//class Program
//{
//    static void Main(string[] args)
//    {

//        //declaring an int array
//        MyGenericArray<int> intArray = new MyGenericArray<int>(5);

//        //setting values
//        for (int c = 0; c < 5; c++)
//        {
//            intArray.setItem(c, c * 5);
//        }

//        //retrieving the values
//        for (int c = 0; c < 5; c++)
//        {
//            Console.Write(intArray.getItem(c) + " ");
//        }

//        Console.WriteLine();

//        //declaring a character array
//        MyGenericArray<char> charArray = new MyGenericArray<char>(5);

//        //setting values
//        for (int c = 0; c < 5; c++)
//        {
//            charArray.setItem(c, (char)(c + 97));
//        }

//        //retrieving the values
//        for (int c = 0; c < 5; c++)
//        {
//            Console.Write(charArray.getItem(c) + " ");
//        }
//        Console.WriteLine();

//        //declaring a string array
//        MyGenericArray<string> stringArray = new MyGenericArray<string>(5);

//        // Setting values
//        for (int c = 0; c < 5; c++)
//        {
//            stringArray.setItem(c, $"String {c}");
//        }

//        // Retrieving the values
//        for (int c = 0; c < 5; c++)
//        {
//            Console.Write(stringArray.getItem(c) + " ");
//        }
//        Console.WriteLine();

//        Console.ReadKey();
//    }
//}

//public class MyGenericArray<T>
//{
//    private T[] array;

//    public MyGenericArray(int size)
//    {
//        array = new T[size + 1];
//    }
//    public T getItem(int index)
//    {
//        return array[index];
//    }
//    public void setItem(int index, T value)
//    {
//        array[index] = value;
//    }
//}

/// Features of Generics
/// 

/// Generic Methods
/// 

//using System;
//using System.Collections.Generic;

//namespace GenericMethodAppl
//{
//    class Program
//    {
//        static void Swap<T>(ref T lhs, ref T rhs)
//        {
//            T temp;
//            temp = lhs;
//            lhs = rhs;
//            rhs = temp;
//        }
//        static void Main(string[] args)
//        {
//            int a, b;
//            char c, d;
//            a = 10;
//            b = 20;
//            c = 'I';
//            d = 'V';

//            //display values before swap:
//            Console.WriteLine("Int values before calling swap:");
//            Console.WriteLine("a = {0}, b = {1}", a, b);
//            Console.WriteLine("Char values before calling swap:");
//            Console.WriteLine("c = {0}, d = {1}", c, d);

//            //call swap
//            Swap<int>(ref a, ref b);
//            Swap<char>(ref c, ref d);

//            //display values after swap:
//            Console.WriteLine("Int values after calling swap:");
//            Console.WriteLine("a = {0}, b = {1}", a, b);
//            Console.WriteLine("Char values after calling swap:");
//            Console.WriteLine("c = {0}, d = {1}", c, d);

//            Console.ReadKey();
//        }
//    }
//}

/// Generic Delegates
/// 

using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);
namespace GenericDelegateAppl
{
    class TestDelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}