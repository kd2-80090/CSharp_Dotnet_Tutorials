
class Circle
{
    public static float _PI;
    int _Radius;

    static Circle()
    {
        Console.WriteLine("In Static Constructor Called");
        Circle._PI = 3.141F;
    }

    public Circle(int Radius)
    {
        Console.WriteLine("Instructor Ctor Called");
        this._Radius = Radius;
    }

    public void PrintRadius()
    {
        Console.WriteLine("Radius : {0}", this._Radius);
    }

    public static void PrintValueOfPI()
    {
        Console.WriteLine("Value of PI : {0}",_PI);
    }

    public float CalculateArea()
    {
        return Circle._PI * this._Radius * this._Radius;
    }
}


class Program
{
    public static void Main()
    {
        //Circle circle = new Circle(5);
        //circle.PrintRadius();
        //Circle.PrintValueOfPI();
        //float Area  = circle.CalculateArea();
        //Console.WriteLine("Area of Circle = {0}",Area);

        //Circle circleObject = new Circle(6);
        //circleObject.PrintRadius();
        //float AreaOfCircle = circleObject.CalculateArea();
        //Console.WriteLine("Area of Circle = {0}", AreaOfCircle);


        Console.WriteLine(Circle._PI);
    }

}