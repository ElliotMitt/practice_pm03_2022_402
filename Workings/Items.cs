﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workings
{
    public partial class Items : Form
    {
        private ItemsTableViewForm itemsTableViewForm;
        public Items()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_shopDataSet);

        }

        private void Items_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.Catalogs". При необходимости она может быть перемещена или удалена.
            this.catalogsTableAdapter.Fill(this.computer_shopDataSet.Catalogs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computer_shopDataSet.Items". При необходимости она может быть перемещена или удалена.
            this.itemsTableAdapter.Fill(this.computer_shopDataSet.Items);

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MoveFirst();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MovePrevious();
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            itemsBindingSource.MoveNext();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            itemsBindingSource.MoveLast();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            itemsBindingSource.AddNew();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            itemsBindingSource.RemoveCurrent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.computer_shopDataSet);
        }

        private void openTableViewBtn_Click(object sender, EventArgs e)
        {
            itemsTableViewForm = new ItemsTableViewForm();
            itemsTableViewForm.Visible = true;
        }
    }
}
