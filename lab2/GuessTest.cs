using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GuessTest
{
    
    [TestMethod]
    public void Check_LowGuess()
    {
        var g = new Guess();
        g.SetSecret(5);
        string result = g.Check(3);
        Assert.IsTrue(result == "Too Low.");
    }
}
