using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CalculatorTest
{
    
    [TestMethod]
    public void Add_InRange_Success()
    {
        var c = new Calculator();
        c.Add(50);
        Assert.IsTrue(c.GetCurrent() == 50);        
        c.Add(50);
        Assert.IsTrue(c.GetCurrent() == 100);
    }
}
