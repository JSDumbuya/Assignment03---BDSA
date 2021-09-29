using System;
using System.Collections.Generic;
using Xunit;

namespace BDSA2021.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void GetWizardsByRowling_given_wizards_returns_only_wizards_by_rowling()
        {
            // Arrange
            var expected = new List<String>{"Harry Potter", "Ron Weasley", "Hermione Granger", "Albus Dumbledore", "Sirius Black", "Mad-Eye Moody", "Severus Snape", "Merlin", "Lord Voldemort", "Lord Voldemort"};
            expected.Sort();
            // Act
            var actualExtension = Queries.GetWizardsByRowlingExtension();
            var actualLINQ = Queries.GetWizardsByRowlingLINQ();
            
            // Assert
            Assert.Equal(expected, actualExtension);
            Assert.Equal(expected, actualLINQ);
        }

        [Fact]
        public void yearFirstSithLordWasIntroduced_returns_1977()
        {
            // Arrange
            var expected = 1977;
           
            // Act
            var actualExtension = Queries.yearFirstSithLordWasIntroducedExtension();
            var actualLINQ = Queries.yearFirstSithLordWasIntroducedLINQ();
            
            // Assert
            Assert.Equal(expected, actualExtension);
            Assert.Equal(expected, actualLINQ);
        }

        [Fact]
        public void UniqueWizards_Doesnt_return_duplicates()
        {
            //Arrange
            IEnumerable<(string, int?)> expected = new List<(string, int?)>{
                ("Harry Potter", 1997),
                ("Ron Weasley", 1997),
                ("Hermione Granger", 1997),
                ("Albus Dumbledore", 1997),
                ("Sirius Black", 2009),
                ("Mad-Eye Moody", 1997),
                ("Severus Snape", 1997),
                ("Merlin", 1997),
                ("Lord Voldemort", 1997),
                ("Lord Voldemort", 2003)
            };

            //Act
            var actualExtension = Queries.UniqueWizardsExtension();
            var actualLINQ = Queries.UniqueWizardsLINQ();

            //Assert
            Assert.Equal(expected, actualExtension);
            Assert.Equal(expected, actualLINQ);
        }
        
        
        [Fact]
        public void ReverseOrderGroupByCreatorReverseOrderWizard_given_wizards_return_ReverseOrderGroupByCreatorReverseOrderWizard(){
            //Arrange
            List<string> expected = new List<string>{
                "Alex Russo",
                "Justin Russo",
                "Max Russo",

                "Alice Quinn",
                "Julia Wicker",
                "Margo Hansen",
                "Quentin Coldwater",
                
                   
                "Gandalf",
                "Sauron",

                "Albus Dumbledore",
                "Harry Potter",
                "Hermione Granger",
                "Lord Voldemort",
                "Lord Voldemort",
                "Mad-Eye Moody",
                "Merlin",
                "Ron Weasley",
                "Severus Snape",
                "Sirius Black", 

                "Darth Vader",
                "Yoda"
            };

            //Act
            var actualExtension = Queries.ReverseOrderGroupByCreatorReverseOrderWizardExtension();
            var actualLINQ = Queries.ReverseOrderGroupByCreatorReverseOrderWizardLINQ();
            
            //Assert
            Assert.Equal(expected, actualExtension);
            Assert.Equal(expected, actualLINQ);
        
        }
    }
}
