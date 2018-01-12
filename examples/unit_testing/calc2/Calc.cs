using System;

public class Calc {
    static void Main() 
    {
        var c = new Calculator();
        Console.WriteLine("c.Current = " + c.Current);
        c.Current = -5;
        Console.WriteLine("c.Current = " + c.Current);
    }
}