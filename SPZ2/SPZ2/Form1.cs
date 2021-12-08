using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ2
{
    public partial class Form1 : Form
    {
        static List<University> universities;
        BindingSource binding;
        public Form1()
        {
            InitializeComponent();
            universities = new List<University>();
            binding = new BindingSource();
            binding.DataSource = universities;
            dataGridView1.DataSource = binding;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string universityName;
            string address;
            int numberOfRooms;
            int numberOfStaff;
            int numberOfStudents;
            decimal paymentForAccommodation;
            bool error = false;

            if (String.IsNullOrEmpty(textBox_name.Text))
            {
                MessageBox.Show("Название университета не может быть пустым!", "Ошибка",
                    MessageBoxButtons.OK);
                textBox_name.Clear();
                error = true;
            }

            if (String.IsNullOrEmpty(textBox_address.Text))
            {
                MessageBox.Show("Строка адреса не может быть пустой!", "Ошибка",
                    MessageBoxButtons.OK);
                error = true;
                textBox_address.Clear();
            }

            if (!error)
            {
                universityName = textBox_name.Text;
                address = textBox_address.Text;
                numberOfRooms = decimal.ToInt32(numericUpDown_rooms.Value);
                numberOfStaff = decimal.ToInt32(numericUpDown_staff.Value);
                numberOfStudents = decimal.ToInt32(numericUpDown_students.Value);
                paymentForAccommodation = numericUpDown_payment.Value;

                University university = new University(universityName, address, numberOfRooms,
                                        numberOfStaff, numberOfStudents, paymentForAccommodation);
                universities.Add(university);

                textBox_name.Clear();
                textBox_address.Clear();
                numericUpDown_rooms.Value = numericUpDown_rooms.Minimum;
                numericUpDown_staff.Value = numericUpDown_staff.Minimum;
                numericUpDown_students.Value = numericUpDown_students.Minimum;
                numericUpDown_payment.Value = numericUpDown_payment.Minimum;
                binding.ResetBindings(true);
            }
        }

        private void button_income_month_Click(object sender, EventArgs e)
        {
            if(universities.Count > 0)
            {
                textBox_income.Text = universities[binding.Position].MonthlyIncome.ToString();
            }
        }

        private void button_income_half_year_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                textBox_income.Text = universities[binding.Position].IncomeHalfAYear().ToString();
            }
        }

        private void button_income_year_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                textBox_income.Text = universities[binding.Position].IncomeYear().ToString();
            }
        }

        private void button_increase_room_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                universities[binding.Position].IncreaseRoom(decimal.ToInt32(numericUpDown_increase.Value));
                binding.ResetBindings(false);
            }
            numericUpDown_increase.Value = numericUpDown_increase.Minimum;
        }

        private void button_settling_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                universities[binding.Position].Settling(decimal.ToInt32(numericUpDown_settling.Value));
                binding.ResetBindings(false);
            }
            numericUpDown_settling.Value = numericUpDown_settling.Minimum;
        }

        private void button_eviction_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                if(numericUpDown_eviction.Value < universities[binding.Position].NumberOfStudents)
                {
                    universities[binding.Position].Eviction(decimal.ToInt32(numericUpDown_eviction.Value));
                    binding.ResetBindings(false);
                }
                else MessageBox.Show("Количество студентов для выселения превышает количество существующих студентов!", "Ошибка",
                 MessageBoxButtons.OK);
            }
            numericUpDown_eviction.Value = numericUpDown_eviction.Minimum;
        }

        private void button_canteen_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                universities[binding.Position].Income_with_canteen();
                binding.ResetBindings(false);
            }
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            if (universities.Count > 0)
            {
                University university = (University)universities[binding.Position].Clone();
                universities.Add(university);
                binding.ResetBindings(true);
            }
            else MessageBox.Show("Нет ни одного университета, чтобы сделать копию!", "Ошибка",
                       MessageBoxButtons.OK);
        }

    }
}
