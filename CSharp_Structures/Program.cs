﻿
/// C# - Structures
/// 

//using System;

//struct Books
//{
//    public string title;
//    public string author;
//    public string subject;
//    public int book_id;
//};

//public class testStructure
//{
//    public static void Main(string[] args)
//    {
//        Books Book1;   /* Declare Book1 of type Book */
//        Books Book2;   /* Declare Book2 of type Book */

//        /* book 1 specification */
//        Book1.title = "C Programming";
//        Book1.author = "Nuha Ali";
//        Book1.subject = "C Programming Tutorial";
//        Book1.book_id = 6495407;

//        /* book 2 specification */
//        Book2.title = "Telecom Billing";
//        Book2.author = "Zara Ali";
//        Book2.subject = "Telecom Billing Tutorial";
//        Book2.book_id = 6495700;

//        /* print Book1 info */
//        Console.WriteLine("Book 1 title : {0}", Book1.title);
//        Console.WriteLine("Book 1 author : {0}", Book1.author);
//        Console.WriteLine("Book 1 subject : {0}", Book1.subject);
//        Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

//        /* print Book2 info */
//        Console.WriteLine("Book 2 title : {0}", Book2.title);
//        Console.WriteLine("Book 2 author : {0}", Book2.author);
//        Console.WriteLine("Book 2 subject : {0}", Book2.subject);
//        Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);

//        Console.ReadKey();
//    }
//}

/// Features of C# Structures
/// 

using System;

struct Books
{
    private string title;
    private string author;
    private string subject;
    private int book_id;

    public void getValues(string t, string a, string s, int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }

    public void display()
    {
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Author : {0}", author);
        Console.WriteLine("Subject : {0}", subject);
        Console.WriteLine("Book_id :{0}", book_id);
    }
};

public class testStructure
{

    public static void Main(string[] args)
    {
        Books Book1 = new Books();   /* Declare Book1 of type Book */
        Books Book2 = new Books();   /* Declare Book2 of type Book */

        /* book 1 specification */
        Book1.getValues("C# Programming",
        "Nilesh Katkar", "C# Programming Tutorial", 6495407);

        /* book 2 specification */
        Book2.getValues("Angular Tutorial",
        "Vaibhav Patil", "Angular Tutorial", 6495700);

        /* print Book1 info */
        Book1.display();

        /* print Book2 info */
        Book2.display();

        Console.ReadKey();
    }
}