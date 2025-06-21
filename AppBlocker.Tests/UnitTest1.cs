using AppBlocker;
using Xunit;
using AppBlockerAddFilesToList;
namespace AppBlocker.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string time = "0600-1400";
        var result = Files.CheckIfTimeFrameValid(time);
        Assert.True(result);
    }
}
