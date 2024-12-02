using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1.Forms.GridTables
{
    public partial class CatalogForm : Form
    {
        private System.Windows.Forms.DataGridViewColumn COL;
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.lAB01DataSet1.Catalogs);

        }

        private void catalogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.catalogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

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
            }

            if (radioButton1.Checked)
                catalogsDataGridView.Sort(COL,
System.ComponentModel.ListSortDirection.Ascending);
            else
                catalogsDataGridView.Sort(COL,
System.ComponentModel.ListSortDirection.Descending);
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.Filter = "Name='" + comboBox1.Text + "'";
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.Filter = "";

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < catalogsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < catalogsDataGridView.RowCount - 1; j++)
                {
                    catalogsDataGridView[i, j].Style.BackColor = Color.White;
                    catalogsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            
            for (int i = 0; i < catalogsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < catalogsDataGridView.RowCount - 1; j++)
                {
                    if (catalogsDataGridView[i,
                    j].Value.ToString().IndexOf(textBox2.Text) != -1)
                    {
                        catalogsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        catalogsDataGridView[i, j].Style.ForeColor = Color.Blue;
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
