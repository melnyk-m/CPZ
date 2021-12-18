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

namespace SPZ5.View
{
    public partial class EditGroup : Form
    {
        string groupName;
        public EditGroup()
        {
            InitializeComponent();
        }
        public EditGroup(int index)
        {
            InitializeComponent();
            groupName = Storage.Students[index].Group.GroupNumber;
            group_textBox.Text = groupName;
        }

        private void rename_button_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(newGroup_textBox.Text))
            {
                Storage.RenameGroup(groupName, newGroup_textBox.Text);
            }
        }

        private void addGroup_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newGroup_textBox.Text))
            {
                Storage.Add(newGroup_textBox.Text);
            }
        }

        private void deleteGroup_button_Click(object sender, EventArgs e)
        {
            Storage.RemoveGroup(groupName);
        }
    }
}
