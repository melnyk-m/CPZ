using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SPZ7.Model;

namespace SPZ7.View
{
    public partial class StudentEditor : Form
    {
        List<string> Student;
        Database database;
        public StudentEditor()
        {
            InitializeComponent();
        }
        public StudentEditor(Database sql)
        {
            InitializeComponent();
            database = sql;
        }
        public StudentEditor(Database sql, string item)
        {
            InitializeComponent();
            database = sql;
            Student = database.GetOneStudent(item);
            id_textBox.Text = Student[0];
            lastname_textBox.Text = Student[1];
            firstname_textBox.Text = Student[2]; 
        }
        private void StudentEditor_Load(object sender, EventArgs e)
        {
            var groupList = database.GetGroups();
            foreach (List<string> items in groupList)
            {
                group_comboBox.Items.Add(items[1]);
            }
            if(Student != null)
            group_comboBox.SelectedItem = Student[3];
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lastname_textBox.Text) && !String.IsNullOrEmpty(firstname_textBox.Text) && !String.IsNullOrEmpty(group_comboBox.SelectedItem.ToString()))
            {
                database.DeleteStudent(Student[0]);
                this.Close();
            }
        }
        private void edit_button_Click(object sender, EventArgs e)
        {
            if (Student != null)
            {
                if (!String.IsNullOrEmpty(lastname_textBox.Text))
                {
                    database.UpdateStudentLastName(lastname_textBox.Text, Student[0]);
                }
                if (!String.IsNullOrEmpty(firstname_textBox.Text))
                {
                    database.UpdateStudentName(firstname_textBox.Text, Student[0]);
                }
                    database.UpdateStudentGroup(group_comboBox.SelectedItem.ToString(), Student[0]);
            }
            this.Close();
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lastname_textBox.Text) && !String.IsNullOrEmpty(firstname_textBox.Text) && !String.IsNullOrEmpty(group_comboBox.SelectedItem.ToString()))
            {
                database.AddStudent(lastname_textBox.Text, firstname_textBox.Text, group_comboBox.SelectedItem.ToString());
                this.Close();
            }
        }
    }
}
