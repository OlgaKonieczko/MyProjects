using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        BuildingElements mathComponent;
        Solution solution;
        StringBuilder operationHistory;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";

            mathComponent = new BuildingElements();
            solution = new Solution(mathComponent.ElementsList);
            operationHistory = new StringBuilder();
        }

        // region - standard numbers and characters assigned
        #region
        private void button12_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('0');
            BtnDisplay('0');
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('1');
            BtnDisplay('1');
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('2');
            BtnDisplay('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('3');
            BtnDisplay('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('4');
            BtnDisplay('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('5');
            BtnDisplay('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('6');
            BtnDisplay('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('7');
            BtnDisplay('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('8');
            BtnDisplay('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('9');
            BtnDisplay('9');
        }


        //Adding
        private void button15_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('+');
            BtnDisplay('+');
        }


        //Substraction
        private void button14_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('-');
            BtnDisplay('-');
        }


        //Multiplication
        private void button13_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('*');
            BtnDisplay('*');
        }

        //Dividing
        private void button16_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('/');
            BtnDisplay('/');
        }

        //Dot
        private void button11_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement(',');
            BtnDisplay(',');
        }


        #endregion


        //C - clear
        private void button19_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('C');
            operationHistory.Clear();
            label1.Text = "";
            label2.Text = "";
        }

        //Solution
        private void button10_Click(object sender, EventArgs e)
        {
            mathComponent.SingleElement('=');
            solution.MathFunction();

            label1.Text = solution.Result.ToString();
            operationHistory.Clear();
            operationHistory.Append(solution.Result.ToString());
        }


        public void BtnDisplay(char character)
        {
            label1.Text = mathComponent.Temp.ToString();
            label2.Text = operationHistory.Append(character).ToString();
        }


    }
}

