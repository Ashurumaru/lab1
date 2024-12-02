using LAB1.Forms.Tables;
using System;
using System.Windows.Forms;

namespace LAB1.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CatalogForm view = new CatalogForm();
            view.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm view = new ProductForm();
            view.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrderForm view = new OrderForm();
            view.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserForm view = new UserForm();
            view.ShowDialog();
        }
    }
}
