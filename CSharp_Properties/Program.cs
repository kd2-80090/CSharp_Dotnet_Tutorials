





/// C# - Properties
/// 

/// Accessors
/// 

//public class Accessors
//{
//    // Declare a Code property of type string:
//    public string code
//    {
//        get
//        {
//            return code;
//        }
//        set
//        {
//            code = value;
//        }
//    }

//    // Declare a Name property of type string:
//    public string name
//    {
//        get
//        {
//            return name;
//        }
//        set
//        {
//            name = value;
//        }
//    }

//    // Declare a Age property of type int:
//    public int age
//    {
//        get
//        {
//            return age;
//        }
//        set
//        {
//            age = value;
//        }
//    }

//    public static void Main()
//    {

//    }
//}

/// Example 
/// 

//using System;
//namespace tutorialspoint
//{
//    class Student
//    {
//        private string code = "N.A";
//        private string name = "not known";
//        private int age = 0;

//        // Declare a Code property of type string:
//        public string Code
//        {
//            get
//            {
//                return code;
//            }
//            set
//            {
//                code = value;
//            }
//        }

//        // Declare a Name property of type string:
//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }

//        // Declare a Age property of type int:
//        public int Age
//        {
//            get
//            {
//                return age;
//            }
//            set
//            {
//                age = value;
//            }
//        }
//        public override string ToString()
//        {
//            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
//        }
//    }

//    class ExampleDemo
//    {
//        public static void Main()
//        {

//            // Create a new Student object:
//            Student s = new Student();

//            // Setting code, name and the age of the student
//            s.Code = "001";
//            s.Name = "Nilesh";
//            s.Age = 24;
//            Console.WriteLine("Student Info: {0}", s);

//            //let us increase age
//            s.Age += 1;
//            Console.WriteLine("Student Info: {0}", s);
//            Console.ReadKey();
//        }
//    }
//}

/// Abstract Properties
/// 

using System;

namespace tutorialspoint
{
    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }
    class Student : Person
    {
        private string code = "N.A";
        private string name = "N.A";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        // Declare a Name property of type string:
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }

    class ExampleDemo
    {
        public static void Main()
        {
            // Create a new Student object:
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Nilesh";
            s.Age = 24;
            Console.WriteLine("Student Info:- {0}", s);

            //let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info:- {0}", s);
            Console.ReadKey();
        }
    }
}