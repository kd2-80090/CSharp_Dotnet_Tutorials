
/// C# - String
/// 

//using System;

//namespace StringApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //from string literal and string concatenation
//            string fname, lname;
//            fname = "Nilesh";
//            lname = "Katkar";

//            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
//            string[] completeSentence = { "Hello", "From", "Xpress", "Team" };

//            string fullname = fname + " " + lname;

//            //by using string constructor { 'H', 'e', 'l', 'l','o' };
//            string greetings = new string(letters);
//            Console.WriteLine("*****************  Greetings: {0} *****************", greetings);

//            Console.WriteLine("Full Name: {0}", fullname);

//            //methods returning string { "Having", "a", "good", "day" };
//            string message = String.Join(" ", completeSentence);
//            Console.WriteLine("Message: {0} !", message);

//            //formatting method to convert a value
//            DateTime waiting = new DateTime(2024, 12, 5, 14, 58, 1);
//            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
//            Console.WriteLine("Message: {0}", chat);

//            Console.WriteLine("*****************************************************");
//        }
//    }
//}

/// Comparing Strings
/// 

//using System;

//namespace StringApplication
//{

//    class StringProg
//    {

//        static void Main(string[] args)
//        {
//            string str1 = "This is test";
//            string str2 = "This is text";

//            if (String.Compare(str1, str2) == 0)
//            {
//                Console.WriteLine(str1 + " and " + str2 + " are equal.");
//            }
//            else
//            {
//                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
//            }
//            Console.ReadKey();
//        }
//    }
//}

/// String Contains String
/// 

//using System;

//namespace StringApplication
//{

//    class StringProg
//    {

//        static void Main(string[] args)
//        {
//            string str = "This is test";

//            if (str.Contains("test"))
//            {
//                Console.WriteLine("The sequence 'test' was found.");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//

/// Getting a Substring
/// 

//using System;

//namespace StringApplication
//{

//    class StringProg
//    {

//        static void Main(string[] args)
//        {
//            string str = "Last night I dreamt of San Pedro";
//            Console.WriteLine(str);
//            string substr = str.Substring(23);
//            Console.WriteLine(substr);
//        }
//    }
//}

/// Joining Strings
/// 

using System;

namespace StringApplication
{

    class StringProg
    {

        static void Main(string[] args)
        {
            string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

            string str = String.Join("\n", starray);
            Console.WriteLine(str);
        }
    }
}