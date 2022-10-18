using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> strList = new List<string>();
        strList.Add("Apples");
        strList.Add("ORANGES");
        strList[1] = "Lemons";

        foreach (var item in strList)
        {
            Console.WriteLine(item);
        }

        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee() { ID = 1001, Name = "San" }) ;
        employees.Add(new Employee() { ID = 1002, Name = "Man" }) ;

        foreach (var item in employees)
        {
            Console.WriteLine($"{item.Name}:{ item.ID}");
        }
    }
}

public class Employee
{
    public Employee()
    {
    }
    public int ID { get; set; }
    public string Name { get; set; }
}