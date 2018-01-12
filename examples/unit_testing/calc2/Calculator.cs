using System;

public class Calculator
{
    private int current;

    public Calculator()
    {
        current = 0;
    }

    public int Current
    {
        get 
        {
            return current;
        }

        set 
        {     
            current = value;
        }
    }

    public void Add(int num)
    {
        if (current >= 0 && num >= 0 && current + num < 0)
        {
            throw new ArgumentException("Overflow");
        }

        current += num;
    }
}
