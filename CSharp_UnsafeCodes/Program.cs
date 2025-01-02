
/// C# - Unsafe Codes
/// 

/// Pointers
/// 

//using System;

//namespace UnsafeCodeApplication
//{
//    class Program
//    {
//        static unsafe void Main(string[] args)
//        {
//            int var = 20;
//            int* p = &var;

//            Console.WriteLine("Data is: {0} ", var);
//            Console.WriteLine("Address is: {0}", (int)p);

//            Console.WriteLine("Data at pointer p : {0}", *p);
//            Console.ReadKey();
//        }
//    }
//}

/// Passing Pointers as Parameters to Methods
/// 

//using System;

//namespace UnsafeCodeApplication
//{
//    class TestPointer
//    {
//        public unsafe void swap(int* p, int* q)
//        {
//            int temp = *p;
//            *p = *q;
//            *q = temp;
//        }
//        public unsafe static void Main()
//        {
//            TestPointer p = new TestPointer();
//            int var1 = 10;
//            int var2 = 20;
//            int* x = &var1;
//            int* y = &var2;

//            Console.WriteLine("Before Swap: var1:{0}, var2: {1}", var1, var2);
//            p.swap(x, y);

//            Console.WriteLine("After Swap: var1:{0}, var2: {1}", var1, var2);
//            Console.ReadKey();
//        }
//    }
//}

/// Accessing Array Elements Using a Pointer
/// 

using System;

namespace UnsafeCodeApplication
{
    class TestPointer
    {
        public unsafe static void Main()
        {
            int[] list = { 10, 100, 200 };
            fixed (int* ptr = list)

                /* let us have array address in pointer */
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
                    Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
                }

            Console.ReadKey();


            unsafe
            {
                int[] list1 = { 10, 20, 30 };
                int* ptr;

                // Without fixed, ptr might point to invalid memory if GC moves the array
                fixed (int* p = list1)
                {
                    ptr = p; // Pinning ensures ptr is valid
                    Console.WriteLine(*ptr); // Prints 10
                }

                // After fixed block, GC might move list, making ptr invalid
                // Accessing ptr here could cause undefined behavior
            }

        }
    }
}