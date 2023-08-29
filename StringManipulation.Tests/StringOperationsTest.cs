using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StringManipulation.Tests
{
    public class StringOperationsTest
    {
        [Fact(Skip = "Test purposes only")]
        public void ConcatenateStrings()
        {
            var strOperation = new StringOperations();

            var result = strOperation.ConcatenateStrings("Hello", "World");

            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Equal("Hello World", result);
            
        }
        [Fact]
        public void IsPalindrome()
        {
            //Arrange
            var strOperations = new StringOperations();

            //Act
            var result = strOperations.IsPalindrome("ama");
            var result2 = strOperations.IsPalindrome("Hello");

            //Assert
            Assert.True(result);
            Assert.False(result2);

        }

        [Fact]
        public void RemoveWhitespace()
        {
            var strOperation = new StringOperations();
            var expectedResults = "HelloWorld";

            var results = strOperation.RemoveWhitespace(expectedResults);

            Assert.Equal(expectedResults, results);
            
        }
        [Fact]
        public void QuantityInWords()
        {
            //Arrange
            var strOperation = new StringOperations();

            //Act
            var result = strOperation.QuantintyInWords("perros", 10);

            //Assert
            Assert.StartsWith("diez", result);
            Assert.Equal("diez perros", result);
            Assert.Contains("perros", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            var strOperation = new StringOperations();

            Assert.ThrowsAny<ArgumentNullException>(() => strOperation.GetStringLength(null));
        }

        [Theory]
        [InlineData("MCMLXXVII", 1977)]
        [InlineData("MCMLXXXII", 1982)]
        public void FromRomanToNumber(string romanNumber, int expected) {
            var strOperation = new StringOperations();

            var result = strOperation.FromRomanToNumber(romanNumber);

            Assert.Equal(expected, result);
        }
    }
}
