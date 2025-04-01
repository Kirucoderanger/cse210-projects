using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Inheritance exercise.");
        Student student = new Student("Brigham", "123");
        string name = student.GetName();
        string number = student.GetNumber();
        //string number1 = base.GetName(); error keyword base is not available in a static method
        Console.WriteLine(name);
        Console.WriteLine(number);
        //Console.WriteLine($"Student Number: {number1}");


        //Book book1 = new Book();//use this where there is no contractor
        Book book1 = new Book();
        book1.SetAuthor("Smith");
        book1.SetTitle("A Great Book");
        Console.WriteLine(book1.GetBookInfo());

        //PictureBook book2 = new PictureBook();//use this where there is no contractor
        PictureBook book2 = new PictureBook();
        book2.SetAuthor("Jones");
        book2.SetTitle("A Wonderful Picture");
        book2.SetIllustrator("Burton");
        Console.WriteLine(book2.GetBookInfo());
        Console.WriteLine(book2.GetPictureBookInfo());

        Book book3 = new Book("Edward", "Another book");
        Console.WriteLine(book3.GetBookInfo());

        PictureBook book4 = new PictureBook("Edward", "Another book", "some one else");
        Console.WriteLine(book4.GetPictureBookInfo());



    }
}