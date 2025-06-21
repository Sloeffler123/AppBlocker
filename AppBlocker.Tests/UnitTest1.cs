using AppBlocker;
using Xunit;
using AppBlockerAddFilesToList;
namespace AppBlocker.Tests;

public class UnitTest1
{
    [Fact]
    public void CheckIfTimeIsTrue()
    {
        Assert.True(Files.CheckIfTimeFrameValid("0600-1400"));
    }
    [Fact]
    public void CheckIfTimeIsFalseShort()
    {
        Assert.False(Files.CheckIfTimeFrameValid("0600-400"));
    }
    [Fact]
    public void CheckifTimeIsFalseLetters()
    {
        Assert.False(Files.CheckIfTimeFrameValid("0600-a400"));
    }
    [Fact]
    public void CheckIfTimeIsFalseLong()
    {
        Assert.False(Files.CheckIfTimeFrameValid("0600-14000"));
    }
}
