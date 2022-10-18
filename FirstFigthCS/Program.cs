// See https://aka.ms/new-console-template for more information

using System;
using Oops;
using System.Diagnostics;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //UsingInheritance();
        //UseOverloading();
        //base clsss =  new derivedclas()
        //VirtuakOverridning();
        IEmpContract i1 = new KpmgEmployee();
        Console.WriteLine($"Sick leave for Employees: {i1.SickLeavesClause()}");
        Console.WriteLine($"Employees should work for {i1.WorkHoursClause()} hours a day");

        IEmpContract i2 = new DellEmployee();
        Console.WriteLine($"Sick leave for Employees: {i2.SickLeavesClause()}");
        Console.WriteLine($"Employees should work for {i2.WorkHoursClause()} hours a day");

    }

    private static void VirtuakOverridning()
    {
        Console.WriteLine("--Parent p = new Child()--");
        Parent parent = new Child();
        parent.ChooseCareer(); //with permission overriding
        parent.NoNightOuts(); // without permission hiding
        Console.WriteLine("--Child ch = new Child()--");
        Child genz = new Child();
        genz.NoNightOuts();
        //abstract
        Shape sh = new Circle() { Radius = 5 };
        sh.Draw();
    }

    private static void UseOverloading()
    {
        ToDo myTodo = new ToDo()
        {
            Name = "Coding",
            StartDate = DateTime.Now.AddDays(-15),
            EndDate = DateTime.Now.AddDays(15),
            IsCompleted = false
        };
        myTodo.Create(0);
        myTodo.Name = "Angular";
        myTodo.StartDate = DateTime.Now.AddDays(-10);
        myTodo.EndDate = DateTime.Now.AddDays(4);
        myTodo.IsCompleted = true;

        myTodo.Create(1);
        myTodo.ViewTodos();
        myTodo.ViewTodos("Coding");
    }

    private static void UsingInheritance()
    {
        Rectangle r1 = new Rectangle(20, 5);
        float area = r1.CalculateArea();
        Console.WriteLine($"Area of R1 with length {r1.Length} and breadth {r1.Breadth} is {area}");

        square sq1 = new square(25);
        area = sq1.CalculateArea();
        Console.WriteLine($"Area of square is {area}");
    }

    private static void CallParmas()
    {
        UseArithematicOperations();
        orderFood();
        DefaultAndNullable("Coding", null);
        DefaultAndNullable("Training", "Angular", true);
        Execute("storedProc", "Name: spSelectAll");
        Execute("Query", "select * from emp", $"where id = 1");

    }
    static void Execute(params string[] p1 )
    {
        Console.WriteLine("Execution details:");
        for(int i = 0; i < p1.Length; i++)
        {
            Console.WriteLine(p1[i]);
        }
    }
    static void DefaultAndNullable(string task,string? details,bool isCompleted = false)
    {
        Console.WriteLine(task);
        Console.WriteLine(details);
        Console.WriteLine(isCompleted);
    }

    private static void orderFood()
    {
        Console.WriteLine("Enter the food Cost: ");
        var scost = Console.ReadLine();
        double cost = Convert.ToDouble(scost);
        gstPrice(cost);

    }

    private static void UseArithematicOperations()
    {
        try
        {
            Calculate(50, 25, "Divide");
            Calculate(50, 25, "Add");
            Calculate(50, 25, "Multiply");
            Calculate(50, 25, "Percentage");

        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Something has gone wrong please contact support :{ex.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    

    static void Calculate(int num1, int num2, string opType)
    {
        Console.WriteLine("");
        switch (opType)
        {
            case "Add":
                Console.WriteLine($"The sum of {num1} and {num2} is: {num1+num2}");
                break;
            case "Subtract":
                Console.WriteLine($"The difference of {num1} and {num2} is: {num1-num2}");
                break;
            case "Multiply":
                Console.WriteLine($"The product of {num1} and {num2} is: {num1*num2}");
                break;
            case "Divide":
                Console.WriteLine($"The division of {num1} and {num2} is:{num1/num2}");
                break;
            default:
                throw new Exception(" Not a valid operation");
        }
    }

    static void gstPrice(double cost)
    {
        Console.WriteLine($"TOTAL COST OF FOOD IS: {cost + cost * 0.18}");
    }
}