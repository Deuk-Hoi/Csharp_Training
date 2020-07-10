using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hello.Text = "응 헬로우 아님";
            hello.Width = 150;

            for(int i = 0;i< 5;i++)
            {
                Button b = new Button();
                Controls.Add(b);
                b.Location = new Point(13, 13 + (23+3) * i);
                b.Text = "동적 생성 " + i + "번째";
                b.Width = 100;
            }
        }

    }
}
