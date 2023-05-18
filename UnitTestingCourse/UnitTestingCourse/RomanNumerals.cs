using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /* ROMAN NUMERALS REFERENCE
        I = 1; V = 5; X = 10; L = 50; C = 100; D = 500; M = 1000
    */ 
    
    public class RomanNumerals
    {

        /* IMPLEMENTATION PLAN
          1) Loop through each string element
            - comparing each char to reference and replacing it with value, return array of values
          2) Starting from last to first, if smaller, subtract from current value, if bigger or equal to, add with following value?
        */

        public static string ParseRomanToArabicNumerals(string romanNum)
        {
            char cha = romanNum.ElementAt(2);
            return cha.ToString();
        } 
    }
}
