// See https://aka.ms/new-console-template for more information
using System;
using EmpClassLib;

class Program
{
    static void Main(string[] args)
    {
        //PersonEmploy();

        //OverrideAbstract();
        IProjectRequirement i1 = new TaxTeam();
        Console.WriteLine(i1.GetUserStory());
        Console.WriteLine(i1.GetStoryStatus());

    }

    private static void OverrideAbstract()
    {
        //Overriding
        Person p2 = new Employee();
        p2.AssignLeave();

        //Abstract
        Person p3 = new Employee() { days = 5 };
        p3.Leave();
    }

    /*private static void PersonEmploy()
    {
        Person p1 = new Person("San", 23);
        Console.WriteLine($"Person is {p1.Name} and age is {p1.Age}");

        Console.WriteLine($"Enter {p1.Name} Employment Details:");
        Console.WriteLine("Enter Employee ID:");
        var rID = Console.ReadLine();
        int ID = Convert.ToInt32(rID);
        Console.WriteLine("Enter Designation:");
        string Des = Console.ReadLine();
        Employee e1 = new Employee(p1.Name, p1.Age, ID, Des);
        Console.WriteLine($"Employee {e1.Name} of age {e1.Age} with Employee ID {e1.Empid} and Designation as {e1.Designation} added successfully!");
    }*/
}
