using System;
using System.IO;
using Xunit;

namespace LeapYear.Tests
{
    public class IsLeapYearTests
    {
        [Theory]
        [InlineData(1600)]
        [InlineData(2104)]
        [InlineData(1664)]
        public void IsLeapYear_returns_true(int year)
        {
            //Arrange

            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.True(output);
        }      

        [Theory]
        [InlineData(1700)]
        [InlineData(1967)]
        [InlineData(5503)]
        public void IsLeapYear_returns_false(int year)
        {
            //Arrange

            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.False(output);
        }  

        [Theory]
        [InlineData("1816", "yay")]
        [InlineData("2100", "nay")]
        [InlineData("2000", "yay")]
        [InlineData("1732", "yay")]
        [InlineData("4106", "nay")]
        public void Main_User_Input(string year, string expected)
        {
            // Arrange
            var reader = new StringReader(year);
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);
            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            // Assert
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Main_input_not_convertible_to_int() {
            // Arrange
            var reader = new StringReader("no");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);
            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            // Assert
            Assert.Equal("Please write an integer", output);
        }

        [Fact]
        public void Main_input_year_before_1582() {
            // Arrange
            var reader = new StringReader("1581");
            Console.SetIn(reader);
            var writer = new StringWriter();
            Console.SetOut(writer);
            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
            // Assert
            Assert.Equal("I only accept years after 1581", output);
        }
    }
}
