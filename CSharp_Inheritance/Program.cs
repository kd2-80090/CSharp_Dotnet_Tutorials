

//public class Employee
//{
//    public string FirstName;
//    public string LastName;
//    public string Email;

//    public Employee()
//    {

//    }

//    public Employee(string FirstName, string LastName, string Email)
//    {
//        this.FirstName = FirstName;
//        this.LastName = LastName;
//        this.Email = Email;
//    }
//    public void PrintFullName()
//    {
//        Console.WriteLine("Name : {0}, {1}",FirstName,LastName );
//    }
//}
//public class FullTimeEmployee : Employee
//{
//    public float YearlySalary;
//    public FullTimeEmployee() { }
//    public FullTimeEmployee(float YearlySalary) 
//    {
//        this.YearlySalary = YearlySalary;
//    }
//}
//public class PartTimeEmployee : Employee
//{
//    float HourlyRate;
//    public PartTimeEmployee() { }
//    public PartTimeEmployee(float HourlyRate)
//    {
//        this.HourlyRate = HourlyRate;
//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        //Console.WriteLine("Welcome");

//        //Employee employee = new Employee("Nilesh","Katkar","nilesh@gmail.com");

//        //employee.PrintFullName();

//        FullTimeEmployee FTEmployee = new FullTimeEmployee();

//        FTEmployee.FirstName = "Akash";
//        FTEmployee.LastName = "Wagh";
//        FTEmployee.Email = "akash@gmail.com";

//        FTEmployee.YearlySalary = 400000;

//        FTEmployee.PrintFullName();

//        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();

//        partTimeEmployee.FirstName = "Shivam";
//        partTimeEmployee.LastName = "Dube";
        
//        partTimeEmployee.PrintFullName();
//    }
//}


public class ParentClass
{
    public ParentClass() 
    {
        Console.WriteLine("In Parent Class CTOR");
    }

    public ParentClass(string message)
    {
        Console.WriteLine(message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived class controlling Parent Class")
    {
        Console.WriteLine("In Child Class CTOR");
    
    }
}

class Program
{
    public static void Main(string[] args)
    {

        ChildClass childClass = new ChildClass();

    }
}