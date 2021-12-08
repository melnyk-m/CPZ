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
    public partial class Authenticationcs : Form
    {
        public StringBuilder key;
        public string name, password;
        string button;
        string item; //= Form1.users_listBox.SelectedItem.ToString();
        public Authenticationcs()
        {
            InitializeComponent();
        }
        public Authenticationcs(string button)
        {
            InitializeComponent();
            key = new StringBuilder();
            this.button = button;
        }
        public Authenticationcs(string button, string item)
        {
            InitializeComponent();
            key = new StringBuilder();
            this.button = button;
            this.item = item;
            name_textBox.Text = item;
            name_textBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(button == "УДАЛИТЬ")
            key.Append(name_textBox.Text + "+" + password_textBox.Text);
           else if(button == "ДОБАВИТЬ")
            {
                name = name_textBox.Text;
                password = password_textBox.Text;
            }
            else
            {
                if (password_textBox.Text != "")
                {
                    foreach(var pair in Form1.programManager.UserDictionary)
                    {
                        if (pair.Value.UserName == item)
                            key.Append(pair.Key);
                    }
                    Form1.programManager.UserDictionary[key.ToString()].Password = password_textBox.Text;
                    MessageBox.Show("Пароль изменён");
                    this.Close();
                }
                else MessageBox.Show("Пароль не изменён");

            }

            this.Close();
        }
    }
}
