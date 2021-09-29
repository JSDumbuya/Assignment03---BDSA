using System;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using System.Collections.Specialized;
using System.Diagnostics.Tracing;

namespace BDSA2021.Assignment03
{
    public static class Queries
    {
        public static Lazy<IReadOnlyCollection<Wizard>> wizards = Wizard.Wizards;

        /*
            LINQ exercise 1
        */
        public static List<string> GetWizardsByRowlingLINQ(){
            IEnumerable<string> q1 = from w in Wizard.Wizards.Value
                 where w.Creator == "J.K. Rowling"
                 orderby w.Name
                 select w.Name;
            return q1.ToList<string>();
        }
        
        public static List<string> GetWizardsByRowlingExtension(){
            var wizardsByRowling = wizards.Value.Where(w => w.Creator.Contains("J.K. Rowling"))
                                                .OrderBy(w => w.Name)
                                                .Select(w => w.Name);                                               
            return wizardsByRowling.ToList<string>();
        }


        /*
            LINQ exercise 2
        */
        public static int? yearFirstSithLordWasIntroducedLINQ(){
            var year = from w in Wizard.Wizards.Value
                where w.Name.StartsWith("Darth")
                orderby w.Year
                select w.Year;
                
            return year.First();
        }

        public static int? yearFirstSithLordWasIntroducedExtension(){
            var year = Wizard.Wizards.Value.Where(w => w.Name.StartsWith("Darth"))
                                            .OrderBy(w => w.Year)
                                            .Select(w => w.Year)
                                            .First();

            return year;
        }


        /*
            LINQ exercise 3
        */
        public static IEnumerable<(string, int?)> UniqueWizardsLINQ(){
            var uniqueWizards = from w in wizards.Value
                                where (w.Medium.StartsWith("Harry Potter")) && (w.Creator == ("J.K. Rowling"))
                                select (w.Name, w.Year);
            return uniqueWizards.Distinct();
        }

        public static IEnumerable<(string, int?)> UniqueWizardsExtension(){
             return wizards.Value.Where(w => w.Medium.StartsWith("Harry Potter") && w.Creator == "J.K. Rowling")
                                                    .Select(w => (w.Name, w.Year))
                                                    .Distinct();                                                                                      
            
        }
        

        /*
            LINQ exercise 4
        */       
        public static List<string> ReverseOrderGroupByCreatorReverseOrderWizardLINQ() {
            var reverseWizards = from w in Wizard.Wizards.Value                               
                                orderby w.Creator descending, w.Name ascending
                                select (w.Name);
            return reverseWizards.ToList<string>();
        }

        public static List<string> ReverseOrderGroupByCreatorReverseOrderWizardExtension() {
            var reverseWizards = Wizard.Wizards.Value.OrderByDescending(w => w.Creator)
                                                        .ThenBy(w => w.Name)
                                                        .Select(w => w.Name);
            return reverseWizards.ToList<string>();
                                                        
        }
    }
}
