

class Customer
{
    string _firstName;
    string _lastName;
    
    public Customer() : this("No FirstName Provided", "No LastName Provided") 
    {

    }

    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullNamwe()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }

    ~Customer()
    {
    }
}

class Program
{
    public static void Main()
    {
        //Customer customer = new Customer("Nilesh", "Katkar");
        Customer customer = new Customer();

        customer.PrintFullNamwe();
    }
}