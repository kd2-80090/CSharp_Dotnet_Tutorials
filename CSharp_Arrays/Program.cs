

//using System;

//namespace ArrayApplication
//{
//    class MyArray
//    {
//        static void Main(string[] args)
//        {
//            int[] n = new int[10]; /* n is an array of 10 integers */
//            int i, j;

//            /* initialize elements of array n */
//            for (i = 0; i < 10; i++)
//            {
//                n[i] = i + 100;
//            }

//            /* output each array element's value */
//            for (j = 0; j < 10; j++)
//            {
//                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
//            }
//            Console.ReadKey();
//        }
//    }
//}


//namespace ArrayApplication
//{
//    class MyArray
//    {
//        static void Main(string[] args)
//        {
//            int[] n = new int[10]; /* n is an array of 10 integers */

//            /* initialize elements of array n */
//            for (int i = 0; i < 10; i++)
//            {
//                n[i] = i + 100;
//            }

//            /* output each array element's value */
//            foreach (int j in n)
//            {
//                int i = j - 100;
//                Console.WriteLine("Element[{0}] = {1}", i, j);
//            }
//            Console.ReadKey();
//        }
//    }
//}

///C# - Multidimensional Arrays
///

//using System;

//namespace ArrayApplication
//{
//    class MyArray
//    {
//        static void Main(string[] args)
//        {
//            /* an array with 5 rows and 2 columns*/
//            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
//            int i, j;

//            /* output each array element's value */
//            for (i = 0; i < 5; i++)
//            {

//                for (j = 0; j < 2; j++)
//                {
//                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}

/// C# - Jagged Array
///

//using System;

//namespace ArrayApplication
//{
//    class MyArray
//    {
//        static void Main(string[] args)
//        {

//            /* a jagged array of 5 array of integers*/
//            int[][] a = new int[][]{
//                new int[]{ 0, 0},
//                new int[]{ 1, 2},
//                new int[]{ 2, 4},
//                new int[]{ 3, 6}, 
//                new int[]{ 4, 8} 
//            };

//            int i, j;

//            /* output each array element's value */
//            for (i = 0; i < 5; i++)
//            {
//                for (j = 0; j < 2; j++)
//                {
//                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}

/// C# - Passing Arrays as Function Arguments
/// 

//using System;

//namespace ArrayApplication
//{
//    class MyArray
//    {
//        double getAverage(int[] arr, int size)
//        {
//            int i;
//            double avg;
//            int sum = 0;

//            for (i = 0; i < size; ++i)
//            {
//                sum += arr[i];
//            }
//            avg = (double)sum / size;
//            return avg;
//        }
//        static void Main(string[] args)
//        {
//            MyArray app = new MyArray();

//            /* an int array with 5 elements */
//            int[] balance = new int[] { 1000, 2, 3, 17, 50 };
//            double avg;

//            /* pass pointer to the array as an argument */
//            avg = app.getAverage(balance, 5);

//            /* output the returned value */
//            Console.WriteLine("Average value is: {0} ", avg);
//            Console.ReadKey();
//        }
//    }
//}

/// C# - Param Arrays
/// 

//using System;

//namespace ArrayApplication
//{
//    class ParamArray
//    {
//        public int AddElements(params int[] arr)
//        {
//            int sum = 0;

//            foreach (int i in arr)
//            {
//                sum += i;
//            }
//            return sum;
//        }
//    }
//    class TestClass
//    {
//        static void Main(string[] args)
//        {
//            ParamArray app = new ParamArray();
//            int sum = app.AddElements(512, 720, 250, 567, 889);

//            Console.WriteLine("The sum is: {0}", sum);
//            Console.ReadKey();
//        }
//    }
//}

/// C# - Array Class
/// 

using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 };
            int[] temp = list;
            Console.Write("Original Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // reverse the array
            Array.Reverse(temp);
            Console.Write("Reversed Array: ");

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //sort the array
            Array.Sort(list);
            Console.Write("Sorted Array: ");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}