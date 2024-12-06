

/// C# - Attributes
/// 

//#define DEBUG
//using System;
//using System.Diagnostics;

//public class Myclass
//{
//    [Conditional("DEBUG")]

//    public static void Message(string msg)
//    {
//        Console.WriteLine(msg);
//    }
//}
//class Test
//{
//    static void function1()
//    {
//        Myclass.Message("In Function 1.");
//        function2();
//    }
//    static void function2()
//    {
//        Myclass.Message("In Function 2.");
//    }
//    public static void Main()
//    {
//        Myclass.Message("In Main function.");
//        function1();
//        Console.ReadKey();
//    }
//}

/// Obsolete
/// 

using System;

public class MyClass
{
    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]

    static void OldMethod()
    {
        Console.WriteLine("It is the old method");
    }
    static void NewMethod()
    {
        Console.WriteLine("It is the new method");
    }
    public static void Main()
    {
        OldMethod();
        //NewMethod();
    }
}

/// Creating Custom Attributes
/// 

/// Declaring a Custom Attribute
/// 

////a custom attribute BugFix to be assigned to a class and its members
//[AttributeUsage(
//   AttributeTargets.Class |
//   AttributeTargets.Constructor |
//   AttributeTargets.Field |
//   AttributeTargets.Method |
//   AttributeTargets.Property,
//   AllowMultiple = true)]

//public class DeBugInfo : System.Attribute

/// Constructing the Custom Attribute
/// 

////a custom attribute BugFix to be assigned to a class and its members
//[AttributeUsage(
//   AttributeTargets.Class |
//   AttributeTargets.Constructor |
//   AttributeTargets.Field |
//   AttributeTargets.Method |
//   AttributeTargets.Property,
//   AllowMultiple = true)]

//public class DeBugInfo : System.Attribute
//{
//    private int bugNo;
//    private string developer;
//    private string lastReview;
//    public string message;

//    public DeBugInfo(int bg, string dev, string d)
//    {
//        this.bugNo = bg;
//        this.developer = dev;
//        this.lastReview = d;
//    }
//    public int BugNo
//    {
//        get
//        {
//            return bugNo;
//        }
//    }
//    public string Developer
//    {
//        get
//        {
//            return developer;
//        }
//    }
//    public string LastReview
//    {
//        get
//        {
//            return lastReview;
//        }
//    }
//    public string Message
//    {
//        get
//        {
//            return message;
//        }
//        set
//        {
//            message = value;
//        }
//    }
//}

/// Applying the Custom Attribute
/// 

//[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
//[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
//class Rectangle
//{
//    //member variables
//    protected double length;
//    protected double width;
//    public Rectangle(double l, double w)
//    {
//        length = l;
//        width = w;
//    }
//    [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]

//    public double GetArea()
//    {
//        return length * width;
//    }
//    [DeBugInfo(56, "Zara Ali", "19/10/2012")]

//    public void Display()
//    {
//        Console.WriteLine("Length: {0}", length);
//        Console.WriteLine("Width: {0}", width);
//        Console.WriteLine("Area: {0}", GetArea());
//    }
//}