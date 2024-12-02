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
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            this.catalogsTableAdapter.Fill(this.lAB01DataSet1.Catalogs);
        }

        private void catalogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.catalogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

        }

        private void firstBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.MoveFirst();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.MovePrevious();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.MoveNext();
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.MoveLast();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.AddNew();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            catalogsBindingSource.RemoveCurrent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            //закрывает подключение с сервером 
            this.catalogsBindingSource.EndEdit();
            //обновляет данные на сервере 
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);
        }

        private void TableBtn_Click(object sender, EventArgs e)
        {
            GridTables.CatalogForm view = new GridTables.CatalogForm();
            view.ShowDialog();
        }
    }
}
