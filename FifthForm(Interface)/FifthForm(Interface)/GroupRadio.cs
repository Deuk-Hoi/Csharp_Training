using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthForm_Interface_
{
    public partial class GroupRadio : Form
    {
        public GroupRadio()
        {
            InitializeComponent();
            List<string> classify = new List<string>() { "식물", "물고기" };
            List<string> food = new List<string>() { "감자", "고구마", "광어", "연어" };
            GroupBox[] groupBoxes = new GroupBox[2];
            RadioButton[] radioButtons = new RadioButton[4];

            for(int i = 0; i<classify.Count; i++)
            {
                groupBoxes[i] = new GroupBox();
                groupBoxes[i].Text = classify[i];
                groupBoxes[i].Size = new Size(120, 100);
                groupBoxes[i].Location = new Point((i * 14) * 10 + 10, 10);
            }

            for(int i = 0; i< food.Count; i++)
            {
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = food[i];
                if(i % 2 == 1)
                {
                    radioButtons[i].Location = new Point(10, 30);
                }
                else
                {
                    radioButtons[i].Location = new Point(10, 60);
                }                
            }

            Button button = new Button();
            button.Text = "클릭";
            button.Location = new Point(10, 120);
            button.Click += ButtonClick;

            for(int i = 0; i< groupBoxes.Length;i++)
            {
                for(int j = 0; j < radioButtons.Length/2; j++)
                {
                    groupBoxes[i].Controls.Add(radioButtons[(i * 1)*2 + j]);
                }
                Controls.Add(groupBoxes[i]);
            }
            Controls.Add(button);

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            foreach(var Groupitem in Controls)
            {
                if(Groupitem is GroupBox)
                {
                    foreach(var item in ((GroupBox)Groupitem).Controls)
                    {
                        RadioButton radio = (item as RadioButton);
                        if(radio != null && radio.Checked)
                        {
                            MessageBox.Show(radio.Text);
                        }
                    }
                }
            }    
        }
    }
}
