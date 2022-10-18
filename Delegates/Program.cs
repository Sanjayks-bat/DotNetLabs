using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Oops;
class Program
{
    public delegate void PM(string requirement);
    static void Main()
    {
        //CallDelegates();
        //simpleLinq();
        //LinqLambdaL2();
        Thread t1 = new Thread(() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Hand Movement animation: y-coordinate = {i}");
            }
        });
        t1.Name = "Hand Animation";
        Thread t2 = new Thread(() =>
        {
            for (int i = 1000; i > 0; i--)
            {
                Console.WriteLine($"Ball Movement animation :: y-coordinate = {i}");

            }
        });
        t2.Name = "Ball Animation";
        t1.Start();
        t2.Start();
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("gAME OVERRRR");
    }

    private static void LinqLambdaL2()
    {
        List<Rectangle> rectangles = new List<Rectangle>();
        rectangles.Add(new Rectangle(10, 5));
        rectangles.Add(new Rectangle(10, 3));
        rectangles.Add(new Rectangle(14, 12));
        rectangles.Add(new Rectangle(25, 3));

        //Query:Get all the rectangles whose length = 10
        rectangles.Where((r) =>
        {
            return r.Length == 10;
        })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth {r.Breadth}");
            });

        //Using Linq ~ SQL in .net
        var searchedRectangles = from r in rectangles where r.Length == 10 select r;

        //Display
        searchedRectangles.ToList().ForEach((r) =>
        {
            Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth ::{r.Length} x {r.Breadth}");

        });

        //Query:Get all rectangles whose breadth = 3
        rectangles.Where((r) =>
        {
            return r.Breadth == 3;
        })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth {r.Breadth}");
            });

        //Using Linq ~ SQL in .net
        var searchedRectangles2 = from r in rectangles where r.Breadth == 3 select r;

        //Display
        searchedRectangles2.ToList().ForEach((r) =>
        {
            Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth ::{r.Length} x {r.Breadth}");

        });

        //Query:Get all rectangles whose breadth = 5 & length = 10
        rectangles.Where((r) =>
        {
            return r.Length == 10 && r.Breadth == 5;
        })
            .ToList()
            .ForEach((r) =>
            {
                Console.WriteLine($"Length: {r.Length} | Breadth {r.Breadth}");
            });

        //Using Linq ~ SQL in .net
        var searchedRectangles3 = from r in rectangles where r.Length == 10 && r.Breadth == 5 select r;

        //Display
        searchedRectangles3.ToList().ForEach((r) =>
        {
            Console.WriteLine($"Output from LINQ: Rectangle Length X Breadth ::{r.Length} x {r.Breadth}");

        });
    }

    private static void simpleLinq()
    {
        List<string> names = new List<string>();
        names.Add("Meena");
        names.Add("Teena");
        names.Add("Reena");
        names.Add("MAYUR");

        names.ForEach((str) =>
        {
            Console.WriteLine(str);
        });

        List<string> result = names.Where((str) =>
        {
            return str == "MAYUR";
        }).ToList();

        Console.WriteLine("Search for 'Mayur'");
        result.ForEach((str) =>
        {
            Console.WriteLine($"Found match for: {str}");
        });

        List<string> result2 = names.Where((str) =>
        {
            return str.StartsWith("Re");
        }).ToList();

        Console.WriteLine("Search for 'Re'");
        result2.ForEach((str) =>
        {
            Console.WriteLine($"Found match for: {str}");
        });



        //orring

        /* List<string> result4 = names.Where((str) =>
         {
             return str.StartsWith("Re") || str.EndsWith("UR");
         }).ToList();
         result4.ForEach((str) =>
         {
             Console.WriteLine($"Found match for: {str}");
         });*/

        Console.WriteLine("----USING linq Anding----");
        var result3 = (from str in names where str.StartsWith("Re") && str.EndsWith("UR") select str).ToList();
        result3.ForEach((str) =>
        {
            Console.WriteLine(str);
        });


        var result4 = (from str in names where str.StartsWith("Re") || str.EndsWith("UR") select str).ToList();
        Console.WriteLine("----USING linq ORRing----");
        result4.ForEach((str) =>
        {
            Console.WriteLine(str);
        });
    }

    private static void CallDelegates()
    {
        PM Vimal = new PM((requirement) => { Console.WriteLine("I, sneha have attended tax training"); });
        Vimal += (requirement) => { Console.WriteLine("I, mayur have attended tax training"); };
        Vimal += (requirement) => { Console.WriteLine("I,  SAN have attended tax training"); };

        Vimal("Taxx training for team");
    }
}