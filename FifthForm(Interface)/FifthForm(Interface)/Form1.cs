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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Button labelbtn = new Button();
            Button checkboxbtn = new Button();
            Button radiobtn = new Button();
            Button groupradio = new Button();


            labelbtn.Text = "라벨 생성";
            checkboxbtn.Text = "체크박스 생성";
            radiobtn.Text = "라디오버튼 생성";
            groupradio.Text = "그룹 라디오 버튼 생성";

            labelbtn.Location = new Point(10, 10);
            checkboxbtn.Location = new Point(10, 40);
            radiobtn.Location = new Point(10, 70);
            groupradio.Location = new Point(10, 100);

            labelbtn.Click += buttonClick;
            checkboxbtn.Click += buttonClick;
            radiobtn.Click += buttonClick;
            groupradio.Click += buttonClick;

            Controls.Add(labelbtn);
            Controls.Add(checkboxbtn);
            Controls.Add(radiobtn);
            Controls.Add(groupradio);
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Labels label = new Labels();
            Checkbox checkbox = new Checkbox();
            Radiobutton radiobutton = new Radiobutton();
            GroupRadio groupRadio = new GroupRadio();

            string btn = sender.ToString();
            string[] token = btn.Split(new string[] { "Text: " }, StringSplitOptions.None);

            if(token[1] == "라벨 생성")
            {
                label.Show();
            }
            else if (token[1]== "체크박스 생성")
            {
                checkbox.Show();
            }
            else if(token[1] == "라디오버튼 생성")
            {
                radiobutton.Show();
            }
            else
            {
                groupRadio.Show();
            }
        }
    }
}
