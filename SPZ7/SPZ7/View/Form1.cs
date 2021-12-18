using System.Collections.Generic;
using System.Windows.Forms;
using SPZ7.Model;
using SPZ7.View;

namespace SPZ7
{
    public partial class Form1 : Form
    {
        Database sql;
        public Form1()
        {
            InitializeComponent();
            sql = new Database();
            UpdateStudents();
            UpdateGroups();
        }
        private void UpdateStudents()
        {
            var lst = sql.GetStudents();
            dataGridView.Rows.Clear();
            foreach (var item in lst)
            {
                dataGridView.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }
        private void UpdateGroups()
        {
            List<List<string>> lst = sql.GetGroups();
            dataGridView1.Rows.Clear();
            foreach (List<string> item in lst)
            {
                dataGridView1.Rows.Add(item[0], item[1]);
            }
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string item = null;
                if (dataGridView.CurrentCell.Value != null)
                {
                    item = dataGridView.CurrentCell.Value.ToString();
                }
                StudentEditor studentEditor;
                if (item != null)
                {
                    studentEditor = new StudentEditor(sql, item);
                }
                else studentEditor = new StudentEditor(sql);
                studentEditor.ShowDialog();
                UpdateStudents();
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string item = null;
                if (dataGridView1.CurrentCell.Value != null)
                {
                    item = dataGridView1.CurrentCell.Value.ToString();
                }
                GroupEditor groupEditor;
                if (item != null)
                {
                    groupEditor = new GroupEditor(sql, item);
                }
                else groupEditor = new GroupEditor(sql);
                groupEditor.ShowDialog();
                UpdateGroups();
                UpdateStudents();
            }

        }
    }
}
