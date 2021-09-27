using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void Q1()
        {
            // Arrange
            var actual = Queries.GetWizardsByRowling();
            var expected = new List<String>{"Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore", "Sirius Black", "Mad-Eye Moody", "Severus Snape", "Merlin", "Lord Voldemort"};
            expected.Sort();
            // Act
            
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void yearFirstSithLordWasIntroduced_returns_1977()
        {
            // Arrange
            var actual = Queries.yearFirstSithLordWasIntroduced();
            var expected = 1977;
           
            // Act
            
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
