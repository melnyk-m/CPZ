using System;

namespace SPZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string FIO, accountNumber;
            Console.Write("Введите ФИО:");
            FIO = Console.ReadLine();
            for(int i = 0; i < FIO.Length; i++)
            {
                while(Char.IsDigit(FIO[i]))
                {
                    Console.Write("Введите корректное значение: ");
                    FIO = Console.ReadLine();
                    i = 0;
                }
            }

            Console.Write("\nВведите номер счёта, состоящий из 8 цифр: ");
            accountNumber = Console.ReadLine();
            for (int i = 0; i < accountNumber.Length; i++)
            {
                while (!Char.IsDigit(accountNumber[i]) || accountNumber.Length != 8)
                {
                    Console.Write("Введите корректное значение: ");
                    accountNumber = Console.ReadLine();
                    i = 0;
                }
            }

            BankUser user = new BankUser(FIO, accountNumber);

            Console.WriteLine(user.ToString());
            do
            {
                Console.WriteLine("\n--Выберите, какое действие хотите совершить--");
                Console.WriteLine("1 - открыть депозит, \n2 - начислить процент, \n3 - пополнить счёт, \n4 - снять средства," +
                    "\n5 - удалить депозит, \n6 - узнать общую сумму депозитов, \n7 - выйти");
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        user.OpenDeposit();
                        break;
                    case 2:
                        user.AccrueInterest();
                        break;
                    case 3:
                        user.Refill();
                        break;
                    case 4:
                        user.Withdrawal();
                        break;
                    case 5:
                        user.Delete_deposit();
                        break;
                    case 6:
                        user.GeneralAmount();
                        break;
                    default: break;
                }
            } while (number != 7);
        }
    }
}
