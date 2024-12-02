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
    public partial class ProductForm : Form
    {
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

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.lAB01DataSet1.Catalogs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.lAB01DataSet1.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.lAB01DataSet1.Catalogs);


        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            //закрывает подключение с сервером 
            this.productsBindingSource.EndEdit();
            //обновляет данные на сервере 
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);
        }

        private void TableBtn_Click(object sender, EventArgs e)
        {
            GridTables.ProductForm view = new GridTables.ProductForm();
            view.ShowDialog();
        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

        }
    }
}
