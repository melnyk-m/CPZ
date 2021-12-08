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
    public partial class ProgramDialog : Form
    {
        public Model.Program program;
        bool flag = false;
        public ProgramDialog()
        {
            InitializeComponent();
        }

        public ProgramDialog(Model.Program prog)
        {
            InitializeComponent();
            program = prog;
            name_textBox.Text = prog.ProgramName;
            name_textBox.Enabled = false;
            OS_textBox.Text = prog.specification.OSType;
            manufacturer_textBox.Text = prog.Manufacturer;
            dateTimePicker.Value = prog.InstallationDate;
            version_numericUpDown.Value = (decimal)prog.Version;
            RAM_numericUpDown.Value = prog.specification.RAM;
            CPU_numericUpDown.Value = (decimal)prog.specification.CPUFrequency;
            HDD_numericUpDown.Value = (decimal)prog.specification.HDDSpace;
            flag = true;
        }
        private void Input_button_Click(object sender, EventArgs e)
        {
            if(!flag)
            { 
                if (name_textBox.Text != "" && OS_textBox.Text != "" && manufacturer_textBox.Text != "" &&
                version_numericUpDown.Value != 0 && RAM_numericUpDown.Value != 0 && CPU_numericUpDown.Value != 0
                && HDD_numericUpDown.Value != 0)
                {
                 program = new Model.Program(name_textBox.Text, OS_textBox.Text, manufacturer_textBox.Text,
                    dateTimePicker.Value, (double)version_numericUpDown.Value, (int)RAM_numericUpDown.Value,
                    (double)CPU_numericUpDown.Value, (double)HDD_numericUpDown.Value);
                 }
            }
           else
            {
                int index = Form1.programManager.ListOfInstalledPrograms.IndexOf(program);
                Form1.programManager.ListOfInstalledPrograms[index].specification.OSType = OS_textBox.Text;
                Form1.programManager.ListOfInstalledPrograms[index].Manufacturer = manufacturer_textBox.Text;
                Form1.programManager.ListOfInstalledPrograms[index].InstallationDate = dateTimePicker.Value;
                Form1.programManager.ListOfInstalledPrograms[index].Version = (double)version_numericUpDown.Value;
                Form1.programManager.ListOfInstalledPrograms[index].specification.RAM = (int)RAM_numericUpDown.Value;
                Form1.programManager.ListOfInstalledPrograms[index].specification.CPUFrequency = (double)CPU_numericUpDown.Value;
                Form1.programManager.ListOfInstalledPrograms[index].specification.HDDSpace = (double)HDD_numericUpDown.Value;
            }
            this.Close();
        }

        
    }
}
