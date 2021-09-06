using System;
using Xunit;

namespace LeapYear.Tests
{
    public class IsLeapYearTests
    {
        [Fact]
        public void IsLeapYear_divBy4_4_returns_true()
        {
            //Arrange
            var year = 4;
            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.True(output);
        }

        [Fact]
        public void IsLeapYear_divBy4_503_returns_false()
        {
            //Arrange
            var year = 503;
            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_divBy4_2104_return_true()
        {
            //Arrange
            var year = 2104;
            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.True(output);
        }

        [Fact]
        public void IsLeapYear_divBy100_500_returns_false()
        {
            //Arrange
            var year = 500;
            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_divBy100_200_returns_false()
        {
            //Arrange
            var year = 200;
            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_divBy400_1600_returns_true()
        {
            //Arrange
            var year = 1600;
            //Act
            Program p = new Program();
            bool output = p.IsLeapYear(year);
            //Assert
            Assert.True(output);
        }
    }
}
