using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jseppa3b1
{
    public class Ex3bCalculations
    {
        // 0 Get Discount Percent
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
            return discountPercent;
        }
       
        // 1 Get Discount Percent using Output Argument
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = .2m;
            else
                discountPercent = .1m;
        }
        
        // 2 Calculate Future Value
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        
        // 3 Calculate Future Value using Ref Argument
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }
        
        // 4 Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = fahrenheit;
            celsius = (fahrenheit - 32) * .555555555555555;
            return celsius;
        }
        
        // 5 Celsius to Fahrenheit
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = (celsius * 1.8) + 32;
        }
       
        // 6 Gross Pay
        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal grossPay = 0m;
            if (hours <= 40m)
                grossPay = hours * rate;
            else
                grossPay = (40m * rate) + ((hours - 40m) * (rate * 1.5m));
            return grossPay;
        }

        // 7 Total Hours
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0m;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }
            return total;
        }

        // 8 String Gross Pay
        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = TotalHours(strNumbers);
            return GrossPay(totalHours, rate);
        }
    }
}
