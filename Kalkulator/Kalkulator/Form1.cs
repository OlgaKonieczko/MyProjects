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

        int formSizeX, formSizeY;
        int numBtnSizeX, numBtnSizeY;
        int btnLocX, btnLocY;
        BuildingElements builder;
        Solution solution;
        StringBuilder mathOperation;

        public Form1()
        {
            InitializeComponent();
            Sizes();
            label1.Text = "";
            label2.Text = "";
            builder = new BuildingElements();
            
            mathOperation = new StringBuilder();
        }

        // region - standard numbers and characters assigned
        #region
        private void button12_Click(object sender, EventArgs e)
        {
            builder.SingleElement('0');
            BtnDisplay('0');
        }
        private void button1_Click(object sender, EventArgs e)
        {
            builder.SingleElement('1');
            BtnDisplay('1');
        }
        private void button2_Click(object sender, EventArgs e)
        {
            builder.SingleElement('2');
            BtnDisplay('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            builder.SingleElement('3');
            BtnDisplay('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            builder.SingleElement('4');
            BtnDisplay('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            builder.SingleElement('5');
            BtnDisplay('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            builder.SingleElement('6');
            BtnDisplay('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            builder.SingleElement('7');
            BtnDisplay('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            builder.SingleElement('8');
            BtnDisplay('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            builder.SingleElement('9');
            BtnDisplay('9');
        }


        //Adding
        private void button15_Click(object sender, EventArgs e)
        {
            builder.SingleElement('+');
            BtnDisplay('+');
        }


        //Substraction
        private void button14_Click(object sender, EventArgs e)
        {
            builder.SingleElement('-');
            BtnDisplay('-');
        }


        //Multiplication
        private void button13_Click(object sender, EventArgs e)
        {
            builder.SingleElement('*');
            BtnDisplay('*');
        }

        //Dividing
        private void button16_Click(object sender, EventArgs e)
        {
            builder.SingleElement('/');
            BtnDisplay('/');
        }

        //Dot
        private void button11_Click(object sender, EventArgs e)
        {
            builder.SingleElement(',');
            BtnDisplay(',');
        }


        #endregion


        //C - clear
        private void button19_Click(object sender, EventArgs e)
        {
            builder.SingleElement('C');
            mathOperation.Clear();
            label1.Text = "";
            label2.Text = "";
        }


        //Solution
        private void button10_Click(object sender, EventArgs e)
        {
            builder.SingleElement('=');
            solution = new Solution(builder.ElementsList);
            solution.MathFunction();
            builder.Equals(solution.Result);
            label1.Text = solution.Result.ToString();
        }



        public void BtnDisplay(char character)
        {
            label1.Text = builder.Temp.ToString();
            label2.Text = mathOperation.Append(character).ToString();
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLocX = ((this.ClientSize.Width - (4 * 70)) / 5);
            btnLocY = (this.ClientSize.Width / 3);
        }

        public void Sizes()

        {
            //form size
            formSizeX = 416;
            formSizeY = 509;
            this.Size = new Size(formSizeX, formSizeY);

            //labels location

            label1.Location = new Point(btnLocX + 200, btnLocY - 50);
            label2.Location = new Point(btnLocX + 200, btnLocY - 100);



            //button sizes
            numBtnSizeX = 70;
            numBtnSizeY = 50;
            Size standardBtn = new Size(numBtnSizeX, numBtnSizeY);

            button1.Size = standardBtn;
            button2.Size = standardBtn;
            button3.Size = standardBtn;
            button4.Size = standardBtn;
            button5.Size = standardBtn;
            button6.Size = standardBtn;
            button7.Size = standardBtn;
            button8.Size = standardBtn;
            button9.Size = standardBtn;
            button10.Size = standardBtn;
            button11.Size = standardBtn;
            button12.Size = new Size(2 * numBtnSizeX + 24, numBtnSizeY);
            button13.Size = standardBtn;
            button14.Size = standardBtn;
            button15.Size = standardBtn;
            button16.Size = standardBtn;
            button17.Size = standardBtn;
            button18.Size = standardBtn;
            button18.Size = standardBtn;


            //button location - first column
            button19.Location = new Point(btnLocX, btnLocY);
            button7.Location = new Point(btnLocX, btnLocY + 60);
            button4.Location = new Point(btnLocX, btnLocY + 120);
            button1.Location = new Point(btnLocX, btnLocY + 180);
            button12.Location = new Point(btnLocX, btnLocY + 240);

            //button location - second column

            button18.Location = new Point(btnLocX + 94, btnLocY);
            button8.Location = new Point(btnLocX + 94, btnLocY + 60);
            button5.Location = new Point(btnLocX + 94, btnLocY + 120);
            button2.Location = new Point(btnLocX + 94, btnLocY + 180);

            //button location - third column

            button17.Location = new Point(btnLocX + 188, btnLocY);
            button9.Location = new Point(btnLocX + 188, btnLocY + 60);
            button6.Location = new Point(btnLocX + 188, btnLocY + 120);
            button3.Location = new Point(btnLocX + 188, btnLocY + 180);
            button11.Location = new Point(btnLocX + 188, btnLocY + 240);

            ////button location - fourth column

            button16.Location = new Point(btnLocX + 282, btnLocY);
            button13.Location = new Point(btnLocX + 282, btnLocY + 60);
            button14.Location = new Point(btnLocX + 282, btnLocY + 120);
            button15.Location = new Point(btnLocX + 282, btnLocY + 180);
            button10.Location = new Point(btnLocX + 282, btnLocY + 240);

        }


    }
}

