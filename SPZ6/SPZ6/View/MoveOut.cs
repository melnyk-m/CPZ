using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ6.Model;

namespace SPZ6.View
{
    public partial class MoveOut : Form
    {
        Hotel hotel;
        public MoveOut()
        {
            InitializeComponent();
        }
        public MoveOut(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;
            if (hotel.HotelDictionary[number] != null)
            {
                hotel.Eviction(number);
                this.Close();
            }
            else MessageBox.Show($"Номер {number} не занят.");
        }
    }
}
