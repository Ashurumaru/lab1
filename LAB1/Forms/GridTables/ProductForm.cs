using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1.Forms.GridTables
{
    public partial class ProductForm : Form
    {
        private System.Windows.Forms.DataGridViewColumn COL;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.lAB01DataSet1.Products);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortBtn.Enabled = true;
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn6;
                    break;
            }

            if (radioButton1.Checked)
                productsDataGridView.Sort(COL,
System.ComponentModel.ListSortDirection.Ascending);
            else
                productsDataGridView.Sort(COL,
System.ComponentModel.ListSortDirection.Descending);
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.Filter = "Name='" + comboBox1.Text + "'";
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.Filter = "";

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < productsDataGridView.RowCount - 1; j++)
                {
                    productsDataGridView[i, j].Style.BackColor = Color.White;
                    productsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < productsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < productsDataGridView.RowCount - 1; j++)
                {
                    if (productsDataGridView[i,
                    j].Value.ToString().IndexOf(textBox2.Text) != -1)
                    {
                        productsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        productsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
