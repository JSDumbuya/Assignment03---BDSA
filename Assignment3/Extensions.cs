using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {   
        public static bool IsSecure(this Uri item) {
            return item.ToString().StartsWith("https:");
        }

        public static int WordCount(this string item){
            return Regex.Matches(item, "\\p{L}+").Count();
        }
    }
}
