
public struct Customer
{
    private int _ID;

    private string _Name;
     
    public int Id
    {
        get { return this._ID; }

        set { this._ID = value; }
    }

    public string Name 
    { 
        get => _Name; 
        set => _Name = value; 
    }

    public Customer(int ID, string Name)
    {
        this._ID = ID;
        this._Name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id = {0}, Name = {1}", this._ID,this._Name);
    }
}


class Program
{
    public static void Main()
    {
        //Console.WriteLine("Welcome to CSharp Tutorial");

        Customer customer = new Customer(101, "Nilesh");
        customer.PrintDetails();

        Customer customer2 = new Customer();
        customer2.Id = 102;
        customer2.Name = "Vaibhav";
        customer2.PrintDetails();

        Customer customer3 = new Customer
        {
            Id = 103,
            Name = "Shrilekh"
        };

        customer3.PrintDetails();
    }
}
