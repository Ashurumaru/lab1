using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1.Forms.Tables
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.lAB01DataSet1.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.lAB01DataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.lAB01DataSet1.Orders);

        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveFirst();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MovePrevious();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveNext();
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveLast();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ordersBindingSource.AddNew();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            ordersBindingSource.RemoveCurrent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            //закрывает подключение с сервером 
            this.ordersBindingSource.EndEdit();
            //обновляет данные на сервере 
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);
        }

        private void ordersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(productIDComboBox.SelectedValue);  

            var product = lAB01DataSet1.Products.FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                double price = (double)product.Price; 

                double count = Convert.ToDouble(countTextBox.Text);

                textBox1.Text = Convert.ToString(price * count);
            }
            else
            {
                MessageBox.Show("Продукт не найден!");
            }
        }
    }
}
