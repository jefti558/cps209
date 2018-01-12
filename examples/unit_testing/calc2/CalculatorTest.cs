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
        Assert.IsTrue(c.Current == 50);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException),"Overflow")]
    public void Add_OutOfRange_Overflow()
    {
        var c = new Calculator();
        c.Current = 2000000000;
        c.Add(2000000000);
        
    }

    [TestMethod]
    public void Add_NegativeInputsOutOfRange_Overflow()
    {
        var c = new Calculator();
        //c.SetCurrent(-2000000000);
        c.Current = -2000000000;
        try {
            c.Add(-2000000000);
            Assert.Fail();
        } catch (ArgumentException e) {
            Assert.IsTrue(e.Message == "Overflow");
        }
        
        
    }    

}
