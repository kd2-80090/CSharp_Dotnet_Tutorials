

/// C# - Preprocessor Directives
/// 

//#define PI 
//using System;

//namespace PreprocessorDAppl
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//#if (PI)
//            Console.WriteLine("PI is defined");
//#else
//            Console.WriteLine("PI is not defined");
//#endif
//            Console.ReadKey();
//        }
//    }
//}


/// Conditional Directives
/// 

#define DEBUG
#define VC_V10
using System;

public class TestClass
{
    public static void Main()
    {
#if (DEBUG && !VC_V10)
         Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
         Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
        Console.WriteLine("DEBUG and VC_V10 are defined");
#else
         Console.WriteLine("DEBUG and VC_V10 are not defined");
#endif
        Console.ReadKey();
    }
}