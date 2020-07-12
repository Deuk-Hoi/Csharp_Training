using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SixthForm_Exception_Handling_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            productBindingSource.Add(new Product() { Name = "교촌치킨", Price = 18000 });
            productBindingSource.Add(new Product() { Name = "페리카나", Price = 19000 });
            productBindingSource.Add(new Product() { Name = "BBQ", Price = 21000 });
            productBindingSource.Add(new Product() { Name = "BHC", Price = 19500 });

            comboBox1.SelectedIndexChanged += DataSelect;
            listBox1.SelectedIndexChanged += DataSelect;

            button1.Click += ButtonClick;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            GridView gridView = new GridView();
            gridView.Show();
        }

        private void DataSelect(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ComboBox combo = (sender as ComboBox);
                Product product = (Product)combo.SelectedItem;
                MessageBox.Show(combo.SelectedValue.ToString());
                MessageBox.Show(product.Name + " : " + product.Price);
            }
            if (sender is ListBox)
            {
                ListBox listbox = (sender as ListBox);
                Product prodect = (Product)listbox.SelectedItem;
                MessageBox.Show(listbox.SelectedValue.ToString());
                MessageBox.Show(prodect.Name + " : " + prodect.Price);
            }
        }
    }
}