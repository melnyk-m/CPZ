using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ1
{
    struct Deposit
    {
        public decimal DepositAmount;
        public decimal Percent;
    }
    class BankUser
    {
        string FIO;
        int[] AccountNumber = new int[8];
        Deposit[] depositArray;
        decimal AccountAmount;
        
        public BankUser(string FIO, string accountNumber)
        {
            this.FIO = FIO;
            for (int i = 0; i < accountNumber.Length; i++)
            {
                AccountNumber[i] = Convert.ToInt32(accountNumber[i]);
            }

            depositArray = new Deposit[4];

            for(int i = 0; i < depositArray.Length; i++)
            {
                depositArray[i].DepositAmount = 0;    
            }    
        }
        public override string ToString()
        {
            return "\nДобро пожаловать, " + FIO + "!";
        }
        decimal InputAmount()
        {
            decimal sum;
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Некорректный ввод! Введите заново: ");
            }
            return sum;
        }
        public void OpenDeposit()
        {
            Console.Write("Сумма депозита для открытия: "); 
            decimal sum = InputAmount();
            Console.Write("Выберите банк: \n\tПриватБанк - 1, \n\tОщадбанк - 2, \n\tUkrsibbank - 3");

            string choice = Console.ReadLine();
            for (int i = 0; i < depositArray.Length; i++)
            {
                if (depositArray[i].DepositAmount == 0)
                {
                    depositArray[i].DepositAmount = sum;
                    switch (choice)
                    {
                        case "1":
                            depositArray[i].Percent = 1m;
                            break;
                        case "2":
                            depositArray[i].Percent = 0.9m;
                            break;
                        case "3":
                            depositArray[i].Percent = 1.8m;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("\nДепозит добавлен!");
                    break;
                }
                else
                    continue;
            }
           
        }
        public void AccrueInterest()
        {
            Console.WriteLine("Начисление процентов по депозиту за год: ");
            for (int i = 0; i < depositArray.Length; i++)
            {
                if (depositArray[i].DepositAmount != 0)
                {
                    Console.Write($"Начальний депозит - {depositArray[i].DepositAmount}," +
                        $" начисление процента - {depositArray[i].DepositAmount * depositArray[i].Percent / 100}");
                  
                    depositArray[i].DepositAmount += depositArray[i].DepositAmount * depositArray[i].Percent / 100;
                    Console.Write($"сумма спустя год - {depositArray[i].DepositAmount}\n");
                }
            }
        }

        public void Refill()
        {
            Console.Write("\nВведите суму для пополнения счёта: ");
            AccountAmount += InputAmount();
            Console.WriteLine($"Сумма после пополнения: {AccountAmount}");
        }
        public void Withdrawal()
        {
            Console.Write("\nВведите суму для снятия средств: ");
            decimal sum = InputAmount();
            if (sum > AccountAmount)
            {
                Console.WriteLine("У вас недостаточно средств.");
                return;
            }
            else
            {
                AccountAmount -= sum;
            }
            Console.WriteLine($"Сумма после снятия: {AccountAmount}");
        }

        public void Delete_deposit()
        {
            
            Console.WriteLine("\nВведите сумму депозита, который хотите удалить: ");
            decimal sum = InputAmount();
                for (int i = 0; i < depositArray.Length; i++)
            {
                if (depositArray[i].DepositAmount == sum)
                {
                        depositArray[i].DepositAmount = 0;
                        depositArray[i].Percent = 0;
                    Console.WriteLine("Депозит удалён.");
                }
            }
        }
        public void GeneralAmount()
        {
            decimal general_deposit = 0;
            for (int i = 0; i < depositArray.Length; i++)
            {
                general_deposit += depositArray[i].DepositAmount;
            }
            Console.WriteLine($"Общая сумма депозитов: {general_deposit}");
        }
    }

}
