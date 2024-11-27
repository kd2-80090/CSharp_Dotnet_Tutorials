
///public access specifier
//using System;

//namespace RectangleApplication
//{
//    class Rectangle
//    {
//        //member variables
//        public double length;
//        public double width;

//        public double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }//end class Rectangle

//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Rectangle r = new Rectangle();
//            r.length = 4.5;
//            r.width = 3.5;
//            r.Display();
//            Console.ReadLine();
//        }
//    }
//}


///private access specifier
//using System;

//namespace RectangleApplication
//{
//    class Rectangle
//    {
//        //member variables
//        private double length;
//        private double width;

//        public void Acceptdetails()
//        {
//            Console.WriteLine("Enter Length: ");
//            length = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter Width: ");
//            width = Convert.ToDouble(Console.ReadLine());
//        }
//        public double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }//end class Rectangle

//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Rectangle r = new Rectangle();
//            r.Acceptdetails();
//            r.Display();
//            Console.ReadLine();
//        }
//    }
//}


///Protected Access Specifier

///Internal Access Specifier
//using System;

//namespace RectangleApplication
//{
//    class Rectangle
//    {
//        //member variables
//        internal double length;
//        internal double width;

//        double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }//end class Rectangle

//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Rectangle r = new Rectangle();
//            r.length = 4.5;
//            r.width = 3.5;
//            r.Display();
//            Console.ReadLine();
//        }
//    }
//}


///Protected Internal Access Specifier

