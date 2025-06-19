using Xunit;
using MidtermApp;

namespace MidtermApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_Add()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }

    [Fact]
    public void Test_Multiply()
    {
        var calc = new Calculator();
        Assert.Equal(6, calc.Multiply(2, 3));
    }

    [Fact]
    public void Test_Subtract()
    {
        var calc = new Calculator();
        Assert.Equal(1, calc.Subtract(3, 2));
    }

    [Fact]
    public void Test_Divide()
    {
        var calc = new Calculator();
        Assert.Equal(2, calc.Divide(4, 2));
    }
}
