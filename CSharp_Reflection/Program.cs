

/// C# - Reflection
/// 

/// Viewing Metadata
/// 

//using System;

//[AttributeUsage(AttributeTargets.All)]
//public class HelpAttribute : System.Attribute
//{
//    public readonly string Url;

//    public string Topic   // Topic is a named parameter
//    {
//        get
//        {
//            return topic;
//        }
//        set
//        {
//            topic = value;
//        }
//    }
//    public HelpAttribute(string url)   // url is a positional parameter
//    {
//        this.Url = url;
//    }

//    private string topic;

//}

//[HelpAttribute("Information on the class MyClass")]
//class MyClass
//{

//}

//namespace AttributeAppl
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            System.Reflection.MemberInfo info = typeof(MyClass);
//            object[] attributes = info.GetCustomAttributes(true);

//            for (int i = 0; i < attributes.Length; i++)
//            {
//                System.Console.WriteLine(attributes[i]);
//            }
//            Console.ReadKey();
//        }
//    }
//}


using System;
using System.Reflection;

namespace BugFixApplication
{
    // A custom attribute BugFix to be assigned to a class and its members
    [AttributeUsage(
       AttributeTargets.Class |
       AttributeTargets.Constructor |
       AttributeTargets.Field |
       AttributeTargets.Method |
       AttributeTargets.Property,
       AllowMultiple = true)]
    public class DeBugInfo : Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;
        public string message;

        public DeBugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }
        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }
        public string Developer
        {
            get
            {
                return developer;
            }
        }
        public string LastReview
        {
            get
            {
                return lastReview;
            }
        }
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

    [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
    class Rectangle
    {
        // Member variables
        protected double length;
        protected double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DeBugInfo(56, "Zara Ali", "19/10/2012")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type type = typeof(Rectangle);

            // Iterating through the attributes of the Rectangle class
            foreach (object attributes in type.GetCustomAttributes(typeof(DeBugInfo), false))
            {
                if (attributes is DeBugInfo dbi)
                {
                    Console.WriteLine("Bug no: {0}", dbi.BugNo);
                    Console.WriteLine("Developer: {0}", dbi.Developer);
                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                    Console.WriteLine("Remarks: {0}", dbi.Message);
                }
            }

            // Iterating through the method attributes
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(typeof(DeBugInfo), true))
                {
                    if (a is DeBugInfo dbi)
                    {
                        Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
                        Console.WriteLine("Developer: {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
                        Console.WriteLine("Remarks: {0}", dbi.Message);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
