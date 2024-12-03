

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a Base Class Print Method");
    }
}

public class DerivedClass : BaseClass
{
    //public override void Print()
    //{
    //    Console.WriteLine("I am Derived Class Print Method");
    //}

    public new void Print()
    {
        Console.WriteLine("I am Derived Class Print Method");
    }
}

public class Program
{
    public static void Main()
    {
        //Console.WriteLine("Method Hiding and Method Overriding Difference");
        BaseClass B = new DerivedClass();

        B.Print();

        DerivedClass D = new DerivedClass();
        D.Print();
    }
}

