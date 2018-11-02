using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jseppa2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            string status = "Standard Rate: ";
            if (subtotal >= 100)
            {
                discountPercent = 0.2m;
                status = "Bulk Rate: " + discountPercent.ToString("n2");
            }
           return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = .2m;
            else if (subtotal >= 200 && subtotal < 300)
                discountPercent = .3m;
            else if (subtotal >= 300)
                discountPercent = .4m;
            else
                discountPercent = .1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 300)
                discountPercent = .4m;
            else if (subtotal >= 200)
                discountPercent = .3m;
            else if (subtotal >= 100)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = (inputB);
            if (customerType == "R")
            {
                if (subtotal >= 100)
                    discountPercent = .2m;
                else
                    discountPercent = .1m;
            }
            else
                discountPercent = .4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0.0m;
            if (inputA != "" && inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                string quantity = inputB;
                decimal subtotal = Decimal.Parse(inputA) * Decimal.Parse(quantity);
                decimal Shipping = 0.0m;
                if (Decimal.Parse(inputA) * Decimal.Parse(quantity) < 50.0m)
                {
                    Shipping = 5.0m;
                }
                else
                {
                    Shipping = 0.0m;
                }
                total = Decimal.Parse(inputA) * Decimal.Parse(quantity) + Shipping;
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal total = 0.0m;
            if (inputA != "" && inputB != "" && Decimal.Parse(inputB) >= Decimal.Parse(inputA))
            {
                decimal start = Decimal.Parse(inputA);
                decimal end = Decimal.Parse(inputB);
                decimal rate = 0.1m;
                decimal difference = end - start;
                total = difference * rate;
                return total.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            decimal total = 0m;
            if (inputA != "" && inputB != "" && Decimal.Parse(inputA) > 0m && Decimal.Parse(inputB) > 0m)
            {
                decimal Sum1 = Decimal.Parse(inputA);
                decimal Sum2 = Decimal.Parse(inputB);
                if (Sum2 >= Sum1)
                {
                    total = Sum2 / Sum1;
                }
                if (Sum1 >= Sum2)
                {
                    total = Sum1 / Sum2;
                }
                return total.ToString("n2");
            }
            return "Invalid input";
        }
    }
}
