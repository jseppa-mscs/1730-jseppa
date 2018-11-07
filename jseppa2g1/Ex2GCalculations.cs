using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jseppa2g1
{
    public class Ex2GCalculations
    {
        public static string Switch01(string customerType)
        {
            //01 Switch w/o Default
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string If01(string customerType)
        {
            //02 Separate 'if' Statements
            decimal discountPercent = -1m;
            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }
        public static string ElseIf01(string customerType)
        {
            //03 Else If
            decimal discountPercent = -1m;
            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse01(string customerType)
        {
            //04 Nested If
            decimal discountPercent = -1m;
            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }

            }
            return discountPercent.ToString("0.0");
        }
        public static string SwitchDefault01(string customerType)
        {
            //05 Switch w/ Default
            decimal discountPercent = -.1m;
            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = .0m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string IfDefault01(string customerType)
        {
            //06 Separate 'if' Statements w/Default
            decimal discountPercent = -.1m;
            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType != "R" && customerType != "C")
                discountPercent = .0m;
            return discountPercent.ToString("0.0");
        }
        public static string ElseIfDefault01(string customerType)
        {
            //07 Else If w/Default
            decimal discountPercent = -.1m;
            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            else
                discountPercent = .0m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElseDefault01(string customerType)
        {
            //08 Nested If w/Default
            decimal discountPercent = -.1m;
            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                {
                    discountPercent = .0m;
                }
            }
            return discountPercent.ToString("0.0");
        }
        public static string Switch02(string customerType)
        {
            //09 Switch 
            decimal discountPercent = -1m;
            switch (customerType)
            {
                case "R":
                case "C":
                    discountPercent = .2m;
                    break;
                case "T":
                    discountPercent = .4m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }
        public static string If02(string customerType)
        {
            //10 If
            decimal discountPercent = -1m;
            if (customerType == "R")
                discountPercent = .2m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType == "T")
                discountPercent = .4m;
            return discountPercent.ToString("0.0");
        }
        public static string ElseIf02(string customerType)
        {
            //11 Else If
            decimal discountPercent = -1m;
            if (customerType == "R" || customerType == "C")
                discountPercent = .2m;
            else if (customerType == "T")
                discountPercent = .4m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse02(string customerType)
        {
            //12 Nested If Else
            decimal discountPercent = -1m;
            if (customerType == "R" || customerType == "C")
            {
                discountPercent = .2m;
            }
            else
            {
                if (customerType == "T")
                {
                    discountPercent = .4m;
                }

            }
            return discountPercent.ToString("0.0");
        }
    }
}
