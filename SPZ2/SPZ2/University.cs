using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ2
{
    class University
    {
        public string UniversityName { get; set; }
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfStaff { get; set; }
        public int NumberOfStudents { get; set; }
        public decimal PaymentForAccommodation { get; set; }
        public decimal MonthlyIncome { get; set; }
        public bool flag = false;

        public University(string universityName, string address,
        int numberOfRooms, int numberOfStaff,
        int numberOfStudents, decimal paymentForAccommodation)
        {
            UniversityName = universityName;
            Address = address;
            NumberOfRooms = numberOfRooms;
            NumberOfStaff = numberOfStaff;
            NumberOfStudents = numberOfStudents;
            PaymentForAccommodation = paymentForAccommodation;
            MonthlyIncome = NumberOfStudents * PaymentForAccommodation;
        }
     
        public object Clone()
        {
            University university = new University(UniversityName,
               Address, NumberOfRooms, NumberOfStaff, NumberOfStudents,
                PaymentForAccommodation);
            return university;
        }
        public void IncreaseRoom(int countRoom)
        {
            NumberOfRooms += countRoom;
        }
        public void Settling(int numberStudent)
        {
            NumberOfStudents += numberStudent;
            MonthlyIncome = NumberOfStudents * PaymentForAccommodation;
        }
        public void Eviction(int numberStudent)
        {
            NumberOfStudents -= numberStudent;
            MonthlyIncome = NumberOfStudents * PaymentForAccommodation;
        }
       /* public decimal IncomeMonth()
        {
            MonthlyIncome = NumberOfStudents * PaymentForAccommodation;
            return income;
        }*/

        public decimal IncomeHalfAYear()
        {
            return MonthlyIncome * 6;
        }
        public decimal IncomeYear()
        {
                return MonthlyIncome * 12;
        }
        public void Income_with_canteen()
        {
            flag = true;
            int number = NumberOfStaff;
            MonthlyIncome = MonthlyIncome.AddCanteen(ref number);
            NumberOfStaff = number;
        }

    }
}

