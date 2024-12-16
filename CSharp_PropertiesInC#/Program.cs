
public class Student
{
    private int _Id;
    private string? _Name;
    private int _PassMark = 35;
    private string? _City;
    private string? _Email;

    public string? Phone
    {
        get; 
        set;   
    }

    public string? AdharNumber{ get; set; }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Student Id cannot be negative");
            }
            this._Id = value;
        }
        get
        {
            return this._Id;
        }
    }

    public int GetId()
    {
        return this.Id;
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }
    }

    public int PassMark
    {
        get
        {
            return this._PassMark;
        }
    }

    public string? City
    {
        set
        {
            this._City = value;
        }
        get
        {
            return this._City;
        }
    }

    public string Email
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Email cannot be null or empty");
            }
            else
            {
                this._Email = value;
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        //Student student = new Student();

        //student.Id = -101;
        //student.Name = null;
        //student.PassMark = 0;

        //Console.WriteLine("Student - \nId : {0}\nName : {1}\nMarks : {2}",student.Id, student.Name, student.PassMark);

        Student s = new Student();

        //s.SetId(-101);

        s.Id = 101;
        //s.SetId(101);
        //s.SetName(null);
        s.Name = "Nilesh";
        //s.PassMark = 24;  // Error

        //Console.WriteLine("Student Id : {0}", s.GetId());
        Console.WriteLine("Student Id : {0}", s.Id);
        Console.WriteLine("Student Name : {0}", s.Name);
        Console.WriteLine("Student Marks : {0}", s.PassMark);

        Console.ReadKey();
    }
}