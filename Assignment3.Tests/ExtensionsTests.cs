using System;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Fact]
        public static void isSecure_given_string_that_startsWith_https_returns_true()
        {
            var uri = new Uri("https://myUrl/../..");
            
            Assert.True(Extensions.IsSecure(uri));
        }

        [Fact]
        public static void wordCount_given_string_return_word_count_as_int(){
            //Arrange
            string input = "en. to tre fire fem, seks syv otte ni ti";
            int expected = 10;
        
            //Act
            int actual = input.WordCount();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
