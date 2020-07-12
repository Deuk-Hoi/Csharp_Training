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
    public partial class Checkbox : Form
    {
        public Checkbox()
        {
            InitializeComponent();

            List<string> food = new List<string>() { "옥수수", "감자", "포도" };
            CheckBox[] checkBox = new CheckBox[3];

            Button button = new Button();

            for (int i = 0; i < food.Count; i++)
            {
                checkBox[i] = new CheckBox();
                checkBox[i].Text = food[i];
                checkBox[i].Location = new Point(10, 20 * (i + 1));
                Controls.Add(checkBox[i]);
            }
            button.Text = "클릭을 해보아요";

            button.Location = new Point(10, 90);
            button.Click += ButtonClick;
            Controls.Add(button);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(var item in Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox box = (item as CheckBox);
                    if(box.Checked)
                    {
                        list.Add(box.Text);
                    }
                }    
            }
            MessageBox.Show(string.Join(", ", list));
        }
    }
}
