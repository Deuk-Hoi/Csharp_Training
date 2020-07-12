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
    public partial class Radiobutton : Form
    {
        public Radiobutton()
        {
            InitializeComponent();

            List<string> food = new List<string>() { "감자", "사과", "배" };
            RadioButton[] radioButtons = new RadioButton[3];
            int spot = 0;
            for (int i = 0; i < food.Count;i++)
            {                
                radioButtons[i] = new RadioButton();
                radioButtons[i].Text = food[i];
                radioButtons[i].Location = new Point(10, spot += 30);
                Controls.Add(radioButtons[i]);
            }

            Button button = new Button();
            button.Text = "클릭";
            button.Location = new Point(10, spot+30);

            button.Click += ButtonClick;
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            foreach(var item in Controls)
            {
                if(item is RadioButton)
                {
                    RadioButton radio = (item as RadioButton);
                    if(radio.Checked)
                    {
                        MessageBox.Show(radio.Text);
                    }
                }
            }
        }
    }
}
