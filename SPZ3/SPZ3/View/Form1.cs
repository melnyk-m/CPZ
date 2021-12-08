using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ3.Model;
using SPZ3.View;

namespace SPZ3
{
    public partial class Form1 : Form
    {
        public static ProgramManager programManager;
        public Form1()
        {
            InitializeComponent();
            programManager = new ProgramManager("Windows 11", 16, 3.6, 1000);
            DisplayPCSpecification();

            Model.Program program1 = new Model.Program("GTA5", "Windows 11", "Rockstar", new DateTime(2021, 12, 1),
                4, 4, 1.8, 28); 
            Model.Program program2 = new Model.Program("Visual Studio 2022", "Windows 11", "Microsoft", new DateTime(2021, 10, 2),
                16.22, 2, 1.8, 20);
            Model.Program program3 = new Model.Program("Minecraft", "Windows 11", "Mojang Studios", new DateTime(2018, 3, 12),
                1.8, 2, 1.8, 25);
            Model.Program program4 = new Model.Program("RAID: Shadow Legends", "Windows 11", "Plarium", new DateTime(2017, 2, 17),
                4.71, 2, 1.8, 5);
            programManager.ProgramInstallation(program1, program2, program3, program4);
            DisplayList();

            User user1 = new User()
            {
                UserName = "User",
                Password = "12345"
            };
            User user2 = new User()
            {
                UserName = "Student",
                Password = "qwerty"
            };
            programManager.AddUser(user1, user2);
            DisplayDictionary();

            programs_listBox.DoubleClick += programs_listBox_DoubleClick;
            users_listBox.DoubleClick += users_listBox_DoubleClick;
            programs_listBox.SelectionMode = SelectionMode.MultiExtended;
            users_listBox.SelectionMode = SelectionMode.MultiExtended;
        }
         void DisplayPCSpecification()
        {
            toolStripStatusLabel.Text = $"Частота процессора: {programManager.specification.CPUFrequency} ГГц," +
                $"ОП: {programManager.specification.RAM} Гб, Жёсткий диск: {programManager.specification.HDDSpace} Гб," +
                $"ОС: {programManager.specification.OSType}";
        }
        void DisplayList()
        {
            programs_listBox.Items.Clear();
            foreach (var prog in programManager.ListOfInstalledPrograms)
            {
                programs_listBox.Items.Add(prog.ProgramName);
            }
        }
       void DisplayDictionary()
        {
            users_listBox.Items.Clear();
            foreach (var user in programManager.UserDictionary)
            {
                users_listBox.Items.Add(user.Value.UserName);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            Authenticationcs dialog = new Authenticationcs(delete_button.Text);
            dialog.ShowDialog();
           
            string key = dialog.key.ToString();
            if (!String.IsNullOrEmpty(key) && programManager.UserDictionary.ContainsKey(key))
            {
                programManager.DeleteUser(key);
                MessageBox.Show("Пользователь удалён");
                DisplayDictionary();
            }
            else MessageBox.Show("Такого пользователя нет");
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            Authenticationcs formAdd = new Authenticationcs(add_button.Text);
            formAdd.ShowDialog();
            if(formAdd.name != null && formAdd.password != null)
            { 
            programManager.AddUser(new User()
            {
                UserName = formAdd.name,
                Password = formAdd.password
            });
            users_listBox.Items.Add(formAdd.name);
            }
        }

        private void installation_button_Click(object sender, EventArgs e)
        {
            ProgramDialog addProgram = new ProgramDialog();
            addProgram.ShowDialog();
            if (addProgram.program != null)
            {
                if (programManager.AvailabilityOfUse(addProgram.program))
                {
                    programManager.ProgramInstallation(addProgram.program);
                    programs_listBox.Items.Add(addProgram.program.ProgramName);
                }
                else MessageBox.Show("Программа не совместима");
            }
        }

        private void programs_listBox_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;

            if (list.SelectedItem != null)
            {
                Model.Program prog = programManager.ListOfInstalledPrograms[list.SelectedIndex];
                ProgramDialog programEditor = new ProgramDialog(prog);
                programEditor.ShowDialog();
                DisplayList();
            }
        }
        private void users_listBox_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;

            if (list.SelectedItem != null)
            {
                Authenticationcs userEditor = new Authenticationcs(null, users_listBox.SelectedItem.ToString());
                userEditor.ShowDialog();
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            int index;
            if ((index = programs_listBox.SelectedIndex) != -1)
            {
                Random random = new Random();
                programManager.ChangeVersion(index, random.NextDouble());
               
            }
        }
        private void uninstallation_button_Click(object sender, EventArgs e)
        {
            int index;
            if ((index = programs_listBox.SelectedIndex) != -1)
            {
                programManager.ProgramDelete(programManager.ListOfInstalledPrograms[index]);
                MessageBox.Show("Прoграмма удалена");
                DisplayList();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            PCSpecificationEditor specificationEditor = new PCSpecificationEditor();
            specificationEditor.ShowDialog();
            DisplayPCSpecification();
        }

        private void compare_button_Click(object sender, EventArgs e)
        {
            CompareUsers();
            ComparePrograms();
        }
        private void CompareUsers()
        {
            string[] names = new string[2];
            int index = 0;
            for (int i = 0; i < programManager.NumberOfUsers; i++)
            {
                if (users_listBox.GetSelected(i))
                {
                    names[index] = users_listBox.Items[i].ToString();
                    if (index < 1)
                        index++;
                    else break;
                }
            }
            if (names[0] != null && names[1] != null)
            {
                if (!programManager.CompareUsers(names[0], names[1]))
                    MessageBox.Show($"Имена пользователей {names[0]} и {names[1]} не равны.");
                else MessageBox.Show("Имена пользователей равны.");
            }
        }
        private void ComparePrograms()
        {
            int[] indexes = new int[2] { -1, -1 };
            int index = 0;
            for (int i = 0; i < programManager.NumberOfInstalledPrograms; i++)
            {
                if (programs_listBox.GetSelected(i))
                {
                    indexes[index] = i;
                    if (index < 1)
                        index++;
                    else break;
                }
            }
            if (indexes[0] != -1 && indexes[1] != -1)
            {
                if (!programManager.ComparePrograms(indexes[0], indexes[1]))
                    MessageBox.Show($"Программы {indexes[0]} и {indexes[1]} совместимы.");
                else MessageBox.Show($"Программы {indexes[0]} и {indexes[1]} не совместимы.");
            }
        }
        private void SelectedItems(out string name, out int index)
        {
            name = default;
            if ((index = programs_listBox.SelectedIndex) != -1 && users_listBox.SelectedItem.ToString() != null)
            {
                name = users_listBox.SelectedItem.ToString();
            }
        }

        private void larger_button_Click(object sender, EventArgs e)
        {
             if (Check(out string name, out int index, out KeyValuePair<string, User> pair))
             {
                if(programManager.UserDictionary[pair.Key].AddToAvailablePrograms(programManager.ListOfInstalledPrograms[index]))
                 MessageBox.Show($"Програма установлена пользователю");
             }
        }

        private void smaller_button_Click(object sender, EventArgs e)
        {
            if (Check(out string name, out int index, out KeyValuePair<string, User> pair))
            {
                if(programManager.UserDictionary[pair.Key].DeleteProgram(programManager.ListOfInstalledPrograms[index]))
                    MessageBox.Show($"Програма удалена у пользователя \"{name}\"");
            }
        }
        bool Check(out string name, out int index, out KeyValuePair<string, User> pair)
        {
            SelectedItems(out name, out index);
            if (name != null && index != -1)
            {
                foreach (var keyValuePair in Form1.programManager.UserDictionary)
                {
                    if (keyValuePair.Value.UserName == name)
                    {
                        pair = keyValuePair;
                        return true;
                    }
                }
            }
            pair = new KeyValuePair<string, User>(null, null);
            return false;
        }
    }
}
