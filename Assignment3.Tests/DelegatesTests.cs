using System;
using System.Collections;
using System.IO;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public static void Reverse_given_string_print_string_in_reverse_order()
        {
            // Arrange
            string s = "hej";
            string expected = "jeh";
            StringWriter strWrt = new StringWriter();
            Console.SetOut(strWrt);

            // Act
            Program.reverse(s);
            var actual = strWrt.ToString().Trim();

            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public static void Product_given_17_58_and_8_10_returns_142_398()
        {
            //Arrange
            double x = 17.58;
            double y = 8.10;

            var expected = 142.398;
            

            //Act
            var actual = Program.calculateProduct(x, y);
            
            //Assert
            Assert.Equal(expected, Math.Round(actual, 3));
        }
        
        [Fact]
        public static void NumericEqual_given_string_0042_and_int_42_returns_true(){
            //Arrange
            bool expected = true;
            string inputString = " 0042";
            int inputInt = 42;

            //Act
            bool actual = Program.numericEqual(inputString, inputInt);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
