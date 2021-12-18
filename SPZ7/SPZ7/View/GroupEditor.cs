using System;
using System.Windows.Forms;
using SPZ7.Model;

namespace SPZ7.View
{
    public partial class GroupEditor : Form
    {
        Database database;
        string idGroup;
        public GroupEditor()
        {
            InitializeComponent();
        }
        public GroupEditor(Database sql)
        {
            InitializeComponent();
            database = sql;
        }
        public GroupEditor(Database sql, string id)
        {
            InitializeComponent();
            database = sql;
            idGroup = id;
            group_textBox.Text = database.GetGroupName(idGroup);
        }

        private void deleteGroup_button_Click(object sender, EventArgs e)
        {
            if (idGroup != null)
            {
                database.DeleteGroup(idGroup);
                this.Close();
            }
        }
        private void rename_button_Click(object sender, EventArgs e)
        {
            if (idGroup != null)
            {
                if (!String.IsNullOrEmpty(newGroup_textBox.Text))
                    database.UpdateGroupName(newGroup_textBox.Text, idGroup);
                this.Close();
            }
        }
        private void addGroup_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newGroup_textBox.Text))
                database.AddGroup(newGroup_textBox.Text);
            this.Close();
        }
    }
}
