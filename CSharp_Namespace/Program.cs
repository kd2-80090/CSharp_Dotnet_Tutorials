
using System;
using PATA = ProjectA.TeamA;
using PATB =  ProjectA.TeamB; 
using System.Collections;
using ProjectA.TeamA;
using ProjectA.TeamB;


class Program
{
    public static void Main()
    {
        //ClassA.Print();
        //ProjectA.TeamB.ClassA.Print();

        PATA.ClassA.Print();
        PATB.ClassA.Print();


    }
        
}

///namespace declaration
//namespace ProjectA
//{

//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team A Print Method");
//            }
//        }
//    }

//}


//namespace ProjectA
//{

//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team B Print Method");
//            }
//        }
//    }

//}