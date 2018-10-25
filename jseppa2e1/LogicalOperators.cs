using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa2e1
{
    public partial class LogicalOperators : Form
    {
        public LogicalOperators()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            result01textbox.Text = "";
            result02textbox.Text = "";
            result03Atextbox.Text = "";
            result03Btextbox.Text = "";
            result04Atextbox.Text = "";
            result04Btextbox.Text = "";
            result05Atextbox.Text = "";
            result05Btextbox.Text = "";
            result06Atextbox.Text = "";
            result06Btextbox.Text = "";
            result07textbox.Text = "";
            result08textbox.Text = "";
            result09Atextbox.Text = "";
            result09Btextbox.Text = "";
            result10textbox.Text = "";

            // #01
            decimal subtotal = Convert.ToDecimal(input01textbox.Text);
            //result01textbox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01textbox.Text = (LogicalOperations.q01(subtotal)).ToString();

            // #02
            int timeInService = Convert.ToInt32(input02textbox.Text);
            //result02textbox.Text = (timeInservice <= 4 || timeInservice >=12).ToString();
            result02textbox.Text = (LogicalOperations.q02(timeInService)).ToString();

            // #03
            bool isValid = Convert.ToBoolean(input03Atextbox.Text);
            int years = Convert.ToInt32(input03Ctextbox.Text);

            // #03
            int counter = Convert.ToInt32(input03Btextbox.Text);
            //result03Atextbox.Text = (isValid == true && counter++ < years).ToString();
            result03Atextbox.Text = (LogicalOperations.q03(isValid, years, counter)).ToString();
            result03Btextbox.Text = counter.ToString();

            // #04
            counter = Convert.ToInt32(input03Btextbox.Text);
            //result04Atextbox.Text = (isValid == true & counter++ < years).ToString();
            result04Atextbox.Text = (LogicalOperations.q04(isValid, years, counter)).ToString();
            result04Btextbox.Text = counter.ToString();

            // #05
            counter = Convert.ToInt32(input03Btextbox.Text);
            //result05Atextbox.Text = (isValid == true || counter++ < years).ToString();
            result05Atextbox.Text = (LogicalOperations.q05(isValid, years, counter)).ToString();
            result05Btextbox.Text = counter.ToString();

            // #06
            counter = Convert.ToInt32(input03Btextbox.Text);
            //result06Atextbox.Text = (isValid == true | counter++ < years).ToString();
            result06Atextbox.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            result06Btextbox.Text = counter.ToString();

            // #07
            DateTime startDate = Convert.ToDateTime(input07Atextbox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07Btextbox.Text);
            DateTime date = Convert.ToDateTime(input07Ctextbox.Text);
            isValid = Convert.ToBoolean(input07Dtextbox.Text);
            //result07textbox.Text = (date > startDate && date < expirationDate || isValid == true).ToString();
            result07textbox.Text = (LogicalOperations.q07(startDate, expirationDate, date, isValid)).ToString();

            // #08
            decimal thisYTD = Convert.ToDecimal(input08Atextbox.Text);
            decimal lastYTD = Convert.ToDecimal(input08Btextbox.Text);
            string empType = input08Ctextbox.Text;
            int startYear = Convert.ToInt32(input08Dtextbox.Text);
            int currentYear = Convert.ToInt32(input08Etextbox.Text);
            //result08textbox.Text = (((thisYTD > lastYTD) || empType == "Part Time") && startYear < currentYear).ToString();
            result08textbox.Text = (LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)).ToString();

            // #09
            counter = Convert.ToInt32(input09Atextbox.Text);
            years = Convert.ToInt32(input09Btextbox.Text);
            //result09Atextbox.Text = (!(counter++ >= years)).ToString();
            result09Atextbox.Text = (LogicalOperations.q09(counter, years)).ToString();
            result09Btextbox.Text = counter.ToString();

            // #10
            int a = Convert.ToInt32(input10Atextbox.Text);
            int b = Convert.ToInt32(input10Btextbox.Text);
            int c = Convert.ToInt32(input10Ctextbox.Text);
            int d = Convert.ToInt32(input10Dtextbox.Text);
            //result10textbox.Text = (a > b && b < c || c < d).ToString();
            result10textbox.Text = (LogicalOperations.q10(a, b, c, d)).ToString();

            // #11
            bool member = Convert.ToBoolean(input11Atextbox.Text);
            decimal price = Convert.ToInt32(input11Btextbox.Text);
            float weight = Convert.ToSingle(input11Ctextbox.Text);
            result11textbox.Text = LogicalOperations.q11(member, price, weight).ToString();

            //#12
            member = Convert.ToBoolean(input12Atextbox.Text);
            price = Convert.ToInt32(input12Btextbox.Text);
            weight = Convert.ToSingle(input12Ctextbox.Text);
            result12textbox.Text = LogicalOperations.q12(member, price, weight).ToString();

            // #13
            string shipState = input13Atextbox.Text;
            string itemType = input13Btextbox.Text;
            result13textbox.Text = LogicalOperations.q13(shipState, itemType).ToString();
        }
    }
}
