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
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();

            productBindingSource.Add(new Product() { Name = "교촌치킨", Price = 18000 });
            productBindingSource.Add(new Product() { Name = "페리카나", Price = 19000 });
            productBindingSource.Add(new Product() { Name = "BBQ", Price = 21000 });
            productBindingSource.Add(new Product() { Name = "BHC", Price = 19500 });
        }
    }
}
