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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.lAB01DataSet1.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lAB01DataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.lAB01DataSet1.Users);

        }
        private void firstBtn_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveFirst();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            usersBindingSource.MovePrevious();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveNext();
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            usersBindingSource.MoveLast();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            usersBindingSource.AddNew();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            usersBindingSource.RemoveCurrent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            //закрывает подключение с сервером 
            this.usersBindingSource.EndEdit();
            //обновляет данные на сервере 
            this.tableAdapterManager.UpdateAll(this.lAB01DataSet1);
        }

        private void TableBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
