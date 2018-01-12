using System;

public class Calculator
{
    private int current;

    public Calculator()
    {
        current = 0;
    }

    public int GetCurrent() 
    {
        return current;
    }

    public void SetCurrent(int newCurrent)
    {
        current = newCurrent;
    }

    public void Add(int num)
    {
        current += num;
    }
}
