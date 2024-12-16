
public class Student
{
    //public int Id { get; set; }
    //public string Name { get; set; }
    //public int PassMark { get; set; }

    private int Id;
    private string Name;
    private int PassMark = 35; 
    public void SetId(int Id)
    {
        if(Id <= 0)
        {
            throw new ArgumentException("Student Id cannot be negative");
        }
        this.Id = Id;
    }

    public int GetId() 
    { 
        return this.Id; 
    }

    public void SetName(string Name)
    {
        if(string.IsNullOrEmpty(Name))
        {
            throw new ArgumentException("Name cannot be null or empty");
        }
        this.Name = Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;
        //if(string.IsNullOrEmpty(Name))
        //{
        //    return "No Name";
        //}
        //else
        //{
        //    return this.Name;
        //}
    }

    public int GetPassMark()
    {
        return this.PassMark;
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

        s.SetId(101);
        //s.SetName(null);
        s.SetName("Nilesh");

        Console.WriteLine("Student Id : {0}", s.GetId());
        Console.WriteLine("Student Name : {0}", s.GetName());
        Console.WriteLine("Student Marks : {0}", s.GetPassMark());

        Console.ReadKey();
    }
}