using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public enum RomArabEnum
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }


        public int ParseRomanToArabicNumerals(string romanNum)
        {
            int conversionResult;
            
            List<int> romArabConversion = new List<int>();


            for (int i = 0; i < romanNum.Length; i++)
            {
                int currentDigit = (int)Enum.Parse(typeof(RomArabEnum), romanNum[i].ToString());

                if (i > 0)
                {
                    if (currentDigit > romArabConversion[i-1])
                    {
                        currentDigit = currentDigit - romArabConversion[i-1] ;
                        romArabConversion.RemoveAt(i - 1);
                        romArabConversion.Add(currentDigit);
                    }
                    else
                    {
                        romArabConversion.Add(currentDigit);
                    }
                }
                else
                {
                    romArabConversion.Add(currentDigit);
                }

            }

            conversionResult = romArabConversion.Sum();

            //Console.WriteLine(string.Join("\t", romArabConversion));
            //Console.Write(conversionResult);

            return conversionResult;


        } 
    }
}
