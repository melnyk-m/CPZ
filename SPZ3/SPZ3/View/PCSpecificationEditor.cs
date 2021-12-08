using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ3.View
{
    public partial class PCSpecificationEditor : Form
    {
        public PCSpecificationEditor()
        {
            InitializeComponent();
            OS_textBox.Text = Form1.programManager.specification.OSType;
            RAM_numericUpDown.Value = Form1.programManager.specification.RAM;
            CPU_numericUpDown.Value = (decimal)Form1.programManager.specification.CPUFrequency;
            HDD_numericUpDown.Value = (decimal)Form1.programManager.specification.HDDSpace;
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            Form1.programManager.specification.OSType = OS_textBox.Text;
            Form1.programManager.specification.RAM = (int)RAM_numericUpDown.Value;
            Form1.programManager.specification.CPUFrequency = (double)CPU_numericUpDown.Value;
            Form1.programManager.specification.HDDSpace = (double)HDD_numericUpDown.Value;
            this.Close();
        }
    }
}
