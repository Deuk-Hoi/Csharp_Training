using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondForm_Method_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Chanege_Click(object sender, EventArgs e)
        {
            if(InchTextBox.Text == "")
            {
                InchTextBox.Text = "값을 입력하시오";
            }
            else
            {
                double inch = int.Parse(InchTextBox.Text);
                double cm = inch * 2.54;
                CmTextBox.Text = cm.ToString();
            }

            if (PoundTextbox.Text == "")
            {
                PoundTextbox.Text = "값을 입력하시오";
            }
            else
            {
                double pound = int.Parse(PoundTextbox.Text);
                double kg = pound * 0.453592;
                KgTextBox.Text = kg.ToString();
            }
        }
    }
}