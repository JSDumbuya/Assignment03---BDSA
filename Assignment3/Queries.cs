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
    

        public static List<string> Q1(){
            IEnumerable<string> q1 = from w in Wizard.Wizards.Value
                 where w.Creator == "J.K. Rowling"
                 orderby w.Name
                 select w.Name;
            return q1.ToList<string>();
        }
        
        public static List<string> GetWizardsByRowling(){
            var wizardsByRowling = from w in wizards.Value
                where w.Creator.Contains("J.K. Rowling")
                orderby w.Name
                select w.Name;
                            
            return wizardsByRowling.ToList<string>();
        }

        public static int? yearFirstSithLordWasIntroduced(){
            var year = from w in Wizard.Wizards.Value
                where w.Name.StartsWith("Darth")
                orderby w.Year
                select w.Year;
                
            return year.First();
        }
/*
        public static List<(string, int)> UniqueWizards(){
            var uniqueWizards = from w in wizards.Value
                                where (w.Medium.StartsWith("Harry Potter")) && (w.Creator.Equals("J.K. Rowling"))
                                select w => Tuple.Create(w.Name, w.Year);
            
            return uniqueWizards.Distinct();
        }
        */
    }
}
