

public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine("Name : {0}, {1}",FirstName,LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine("Name : {0}, {1}", FirstName, LastName);
    }
}

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine("Name : {0}, {1} - Contractor", FirstName, LastName);
        //base.PrintFullName();
    }
}

class Program
{
    public static void Main()
    {
        //Console.WriteLine("Hello, World!");

        FullTimeEmployee employee = new FullTimeEmployee();
        employee.FirstName = "Vaibhav";
        employee.LastName = "Patil";

        employee.PrintFullName();

        //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        //partTimeEmployee.FirstName = "Onkar";
        //partTimeEmployee.LastName = "Bhosale";

        //partTimeEmployee.PrintFullName();

        //((Employee)partTimeEmployee).PrintFullName();


        Employee partTimeEmployee = new PartTimeEmployee();
        partTimeEmployee.FirstName = "Onkar";
        partTimeEmployee.LastName = "Bhosale";

        partTimeEmployee.PrintFullName();
    }
}