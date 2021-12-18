using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SPZ6.Model;
using SPZ6.View;

namespace SPZ6
{
    public partial class Form1 : Form
    {
        int occupied = 0;
        object obj = new object();
        object obj1 = new object();
        Hotel hotel = new Hotel();
        public int Occupied
        {
            get => occupied;
            set
            {
                occupied = value;
                if (occupied > hotel.CountRooms - hotel.CountRooms * 0.1)
                    checkIn = false;
                else
                { checkIn = true; Hundred = false; }
                if (occupied == hotel.CountRooms)
                    Hundred = true;
            }
        }
        public int free;
        public bool Hundred = false;
        bool checkIn = true;
        public Form1()
        {
           InitializeComponent();
           all_label.Text = hotel.CountRooms.ToString();
            Random rand = new Random();
            int numberOccupiedRooms = rand.Next(30, 60);
            Thread t = new Thread(() => Filling(numberOccupiedRooms));
            t.Start();
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        }
        void DataUpdater(string str)
        {
            if (occupied_label.InvokeRequired)
                occupied_label.Invoke(new Action<string>(DataUpdater), str);
            else
            {
                occupied_label.Text = str;
                free = hotel.CountRooms - Occupied;
                free_label.Text = free.ToString();

                new Thread(() => Serialization.Serialize(hotel)).Start();
            }
        }
        void IncomeUpdater(string str)
        {
            if (incomeLabel.InvokeRequired)
                incomeLabel.Invoke(new Action<string>(IncomeUpdater), str);
            else
            {
                incomeLabel.Text = str;
            }
        }
        public void FillingWithTourists()
        {
            while (occupied < 100)
            {
                Filling(hotel.CountRooms);
            }
        }
        public void Filling(int numberOccupiedRooms)
        {
            Random rand = new Random();
            for (int i = 1; i <= numberOccupiedRooms; i++)
            {
                int number = rand.Next(1, hotel.CountRooms + 1);
                if (hotel.HotelDictionary[number] == null)
                {
                    lock(obj)
                    {
                        hotel.HotelRooms[number - 1].Settling();
                        hotel.HotelDictionary[number] = new Occupant();
                        Occupied++;
                        DataUpdater(Occupied.ToString());   
                    }
                    lock(obj1)
                    {
                        hotel.Income += hotel.HotelDictionary[number].Days * hotel.HotelRooms[number - 1].Price;
                        IncomeUpdater(hotel.Income.ToString());
                    }
                    Thread.Sleep(50);
                }
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                if (!Hundred && checkIn)
                {
                    Thread t = new Thread(FillingWithTourists);
                    t.Start();
                }
            }
        }

        private void moveOut_button_Click(object sender, EventArgs e)
        {
            hotel.occupied = Occupied;
            MoveOut moveOut = new MoveOut(hotel);
            moveOut.ShowDialog();
            Occupied = hotel.occupied;
            DataUpdater(Occupied.ToString());
        }

        private void moveIn_button_Click(object sender, EventArgs e)
        {
            if (Hundred && !checkIn)
                MessageBox.Show("Для заселения нужно освободить 10% номеров");

            else
            {
                hotel.Settling();
                Occupied++;
                DataUpdater(Occupied.ToString());
                IncomeUpdater(hotel.Income.ToString());
            }
        }
    }
}
