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
    public partial class Labels : Form
    {
        public Labels()
        {
            InitializeComponent();

            Label label = new Label()
            {
                Text = "글자",
                Location = new Point(10, 10)
            };
            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "링크라벨",
                Location = new Point(10, 50)
            };
            linkLabel.Click += LabelClick;
            Controls.Add(label);
            Controls.Add(linkLabel);
        }

        private void LabelClick(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://www.naver.com");
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
