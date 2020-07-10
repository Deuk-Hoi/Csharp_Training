using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdForm_Inheritance_Polymorphism_
{
    public partial class Form1 : Form
    {

        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "제목 글자";
            }
        }
        public Form1()
        {
            InitializeComponent();
            Button b = new Button();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("hello");
            MessageBox.Show("Hodu","안녕하세요");
            MessageBox.Show("Deuk", "안뇽하세요", MessageBoxButtons.RetryCancel);*/
            /*DialogResult result;
            do
            {
                result = MessageBox.Show("Deuk", "안뇽하세요", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);*/
            CustomForm form = new CustomForm();
            //form.Show(); //모달리스 (기존 화면 조작 가능)
            form.ShowDialog(); //모달 (기존화면 조작 불가능)

        }
    }
}
