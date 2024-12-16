
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Customer() { }

    ~Customer() { }
}

public struct Customer1
{
    public int Id { get; set; }
    public string Name { get; set; }

    //public Customer1() { }    // Error - Struct cannot have explicit parameterless ctor

    //~Customer() { }   // Error - Struct cannot have destructors
}

class Program
{
    public static void Main()
    {
        //Console.WriteLine("Welcome");

        //System.Int32 i = 0;
        //int i = 0;

        //if (i == 10) 
        //{
        //    int j = 20;
        //    Customer customer = new Customer();
        //    customer.Id = 101;
        //    customer.Name = "Nilesh";
        //}

        int i = 10;
        int j = i;
        j=j+1;

        Console.WriteLine("i = {0} && j = {1}",i,j);

        Customer customer = new Customer();
        customer.Id = 101;
        customer.Name = "Shivam";

        Customer customer2 = customer;

        customer2.Name = "Khushi";

        Console.WriteLine("customer.Name = {0} && customer2.Name = {1}", customer.Name, customer2.Name);
    }
}