

using System;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //from string literal and string concatenation
            string fname, lname;
            fname = "Nilesh";
            lname = "Katkar";

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string[] completeSentence = { "Hello", "From", "Xpress", "Team" };

            string fullname = fname + " " + lname;

            //by using string constructor { 'H', 'e', 'l', 'l','o' };
            string greetings = new string(letters);
            Console.WriteLine("*****************  Greetings: {0} *****************", greetings);

            Console.WriteLine("Full Name: {0}", fullname);

            //methods returning string { "Having", "a", "good", "day" };
            string message = String.Join(" ", completeSentence);
            Console.WriteLine("Message: {0} !", message);

            //formatting method to convert a value
            DateTime waiting = new DateTime(2024, 12, 5, 14, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            Console.WriteLine("*****************************************************");
        }
    }
}