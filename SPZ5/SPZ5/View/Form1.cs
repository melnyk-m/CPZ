using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ5.Model;
using SPZ5.View;
using System.IO;

namespace SPZ5
{
    public partial class Form1 : Form
    {
        BindingSource bsDataGrid;
        BindingSource bsCombobox;
        static string StoragePath { get; } = "Storage.xml";
        static string GroupListPath { get; } = "GroupList.xml";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(StoragePath) && File.Exists(GroupListPath))
            {
                Storage.Students = Serialization.Deserialize(StoragePath, Storage.Students);
                Storage.Groups = Serialization.Deserialize(GroupListPath, Storage.Groups);
                File.Delete(StoragePath);
            }
            else Storage.Generate();
           
            bsDataGrid = new BindingSource();
            bsDataGrid.DataSource = Storage.Students;
            dataGridView.DataSource = bsDataGrid;

            bsCombobox = new BindingSource();
            bsCombobox.DataSource = Storage.Groups;
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                if (e.RowIndex > -1)
                {
                    EditGroup edit = new EditGroup(e.RowIndex);
                    edit.ShowDialog();
                    bsDataGrid.ResetBindings(true);
                    bsCombobox.ResetBindings(true);
                }
            }  
        }

        private void dataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    Storage.Students = Storage.SortByName(Storage.Students);
                    bsDataGrid.DataSource = Storage.Students;
                    break;
                case 2:
                    bsDataGrid.DataSource = Storage.SortByNumberOfStudents(); ;
                    break;
            }
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            ChooseGroup choose = new ChooseGroup();
            choose.ShowDialog();
            if(!string.IsNullOrEmpty(choose.groupName))
            {
                bsDataGrid.DataSource = Storage.OutputList(choose.groupName);
            }
        }
        private void all_button_Click(object sender, EventArgs e)
        {
            bsDataGrid.DataSource = Storage.Students;
        }
    }
}
