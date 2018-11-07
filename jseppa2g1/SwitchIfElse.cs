using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jseppa2g1
{
    public partial class SwitchIfElse : Form
    {
        public SwitchIfElse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //01 Switch
            resultSwitch01textbox.Text = Ex2GCalculations.Switch01(input1Atextbox.Text);

            //02 If
            resultIf01textbox.Text = Ex2GCalculations.If01(input1Atextbox.Text);

            //03 Else If
            resultElseIf01textbox.Text = Ex2GCalculations.ElseIf01(input1Atextbox.Text);

            //04 Nested If
            resultNestedIfElse01textbox.Text = Ex2GCalculations.NestedIfElse01(input1Atextbox.Text);

            //05 Switch w/Default
            resultSwitchDefault01textbox.Text = Ex2GCalculations.SwitchDefault01(input1Atextbox.Text);

            //06 If w/Default
            resultIfDefault01textbox.Text = Ex2GCalculations.IfDefault01(input1Atextbox.Text);

            //07 Else If w/Default
            resultElseIfDefault01textbox.Text = Ex2GCalculations.ElseIfDefault01(input1Atextbox.Text);

            //08 Nested If w/Default
            resultNestedIfElseDefault01textbox.Text = Ex2GCalculations.NestedIfElseDefault01(input1Atextbox.Text);

            //09 
            resultSwitch02textbox.Text = Ex2GCalculations.Switch02(input2Atextbox.Text);

            //10
            resultIf02textbox.Text = Ex2GCalculations.If02(input2Atextbox.Text);

            //11
            resultElseIf02textbox.Text = Ex2GCalculations.ElseIf02(input2Atextbox.Text);

            //12
            resultNestedIfElse02textbox.Text = Ex2GCalculations.NestedIfElse02(input2Atextbox.Text);
        }
    }
}
