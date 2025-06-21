
using AppBlockerAddFilesToList;
namespace AppBlockerUnitTestProgram.Tests
{
    public class UnitTestProgram
    {
        [Fact]
        public void Check_If_Time_Is_True()
        {
            Assert.True(Files.CheckIfTimeFrameValid("0600-1400"));
        }
        [Fact]
        public void Check_If_Time_Is_FalseShort()
        {
            Assert.False(Files.CheckIfTimeFrameValid("0600-400"));
        }
        [Fact]
        public void Check_If_Time_Is_FalseLetters()
        {
            Assert.False(Files.CheckIfTimeFrameValid("0600-a400"));
        }
        [Fact]
        public void Check_If_Time_Is_FalseLong()
        {
            Assert.False(Files.CheckIfTimeFrameValid("0600-14000"));
        }
    }
}

