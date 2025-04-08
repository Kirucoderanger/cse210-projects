using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Employee employee = new Employee();
        Console.WriteLine(employee.CalculatePay());
        HourlyEmployee hourlyEmployee = new HourlyEmployee();
        hourlyEmployee.CalculatePay();
        Console.WriteLine(hourlyEmployee.CalculatePay());
        // Create a list of Employees
        List<Employee> employees = new List<Employee>();

        // Create different kinds of employees and add them to the same list
        employees.Add(new Employee());
        employees.Add(new HourlyEmployee());

        // Get a custom calculation for each one
        foreach(Employee employee1 in employees)
        {
        float pay = employee1.CalculatePay(); //Polymorphism in Action
        Console.WriteLine(pay);
        }

         static void DisplayPayCheck(Employee e)
    {
        float pay = e.CalculatePay();
        Console.WriteLine(pay);
        // ...
    }
        DisplayPayCheck(employee);
        DisplayPayCheck(hourlyEmployee);

    static Employee GetManager()
    {
        // ... code here to find the manager ...
        // For now, just return a new Employee
        // or HourlyEmployee
        // depending on your needs
        Employee returnEmployee = new Employee();
        HourlyEmployee returnEmployee1 = new HourlyEmployee();
        return returnEmployee1;

        //return theManager;
    }

    static void DisplayManagerPay()
    {
        Employee manager = GetManager();
        float pay = manager.CalculatePay();
        // ...
        Console.WriteLine(pay);
    }
    DisplayManagerPay();

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the list
        shapes.Add(new Square("red", 5)); // Assuming Square constructor takes side length
        shapes.Add(new Circle("blue", 5)); // Assuming Circle constructor takes radius
        shapes.Add(new Rectangle("green", 5, 10)); // Assuming Rectangle constructor takes length and width

        // Calculate the area for each shape
        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();  // Assuming Shape has a Color property
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        
    }
}