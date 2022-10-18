using System;
class Program
{
    public delegate void CA(int n1, int n2);

    static void Main()
    {
        CA Calculate = new CA((n1,n2) =>{ Console.WriteLine($"Sum: {n1 + n2}");});
        Calculate += (n1, n2) => { Console.WriteLine($"Difference: {n1 - n2}"); };
        Calculate += (n1, n2) => { Console.WriteLine($"Product: {n1 * n2}"); };
        Calculate += (n1, n2) => { Console.WriteLine($"Division: {n1 / n2}"); };

 
        Calculate(25, 5);
    }

}