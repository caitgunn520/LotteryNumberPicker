using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variables to hold lottery numbers
        int num1, num2, num3, num4, num5, num6;
        const int MAX = 51;

        //generator for lottery numbers
        Random lotNumGen = new Random();
        
        private void generateButton_Click(object sender, EventArgs e)
        {
            num1 = lotNumGen.Next(1, MAX);

            do
            {
                num2 = lotNumGen.Next(1, MAX);
            }
            while (num2 == num1);

            do
            {
                num3 = lotNumGen.Next(1, MAX);
            }
            while (num3 == num1 || num3 == num2);

            do
            {
                num4 = lotNumGen.Next(1, MAX);
            }
            while (num4 == num1 || num4 == num2 || num4 == num3);

            do
            {
                num5 = lotNumGen.Next(1, MAX);
            }
            while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4);

            do
            {
                num6 = lotNumGen.Next(1, MAX);
            }
            while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5);

            outputLabel.Text = $"Your lottery numbers are: {num1} {num2} {num3} {num4} {num5} {num6}";
        }
    }
}
