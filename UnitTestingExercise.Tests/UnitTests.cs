using System;
using Xunit;
using UnitTestingExercise;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(10, 12, 0, 22)]
        [InlineData(1, -8, 4, -3)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            var actual = sut.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(25, 13, 12)]
        [InlineData(10, 20, -10)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            var actual = sut.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 4, 8)]
        [InlineData(10, 5, 50)]
        [InlineData(10, -2, -20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            var actual = sut.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 5, 3)]
        [InlineData(30, 6, 5)]
        [InlineData(5, 0, null)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            var actual = sut.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OnePlusOne()
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            int num1 = 1;
            int num2 = 1;
            var actual = sut.OnePlusOne(num1, num2);
            //Assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void TwoTimesTwo()
        {
            //Arrange
            var sut = new UnitTestMethods();
            //Act
            int num1 = 2;
            int num2 = 2;
            var actual = sut.TwoTimesTwo(num1, num2);
            //Assert
            Assert.Equal(4, actual);
        }
    }
}
