using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeventhForm_Delegate_Lamda_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Delegate_Lamda();
            Save_Example();
            Save_text();
        }
        public void Delegate_Lamda()
        {
            Button button = new Button();
            button.Text = "무명, 람다";
            button.Location = new Point(10, 10);
            button.Click += delegate (object sender, EventArgs args)
            {
                MessageBox.Show("무명 델리게이터를 사용한 이벤트 입니다.");
            };
            button.Click += (sender, args) => MessageBox.Show("람다를 사용한 이벤트 입니다.");
            Controls.Add(button);
        }
        public void Save_Example()
        {
            button1.Click += (sender, args) =>
            {
                saveFileDialog1.ShowDialog();
                MessageBox.Show(saveFileDialog1.FileName);
            };
        }
        public void Save_text()
        {
            button2.Click += (sender, args) =>
            {
                saveFileDialog1.Filter = "텍스트 파일 (*.txt)|*.txt";
                saveFileDialog1.ShowDialog();
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            };
        }
    }
}
