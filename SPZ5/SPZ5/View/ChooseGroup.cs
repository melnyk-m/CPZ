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
    public partial class ChooseGroup : Form
    {
        public string groupName;
        public ChooseGroup()
        {
            InitializeComponent();
           output_comboBox.Items.AddRange(Storage.Groups.ToArray());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(output_comboBox.SelectedIndex > -1)
            {
                groupName = output_comboBox.SelectedItem.ToString();
                this.Close();
            }
        }
    }
}
