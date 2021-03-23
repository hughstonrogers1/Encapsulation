using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();

            Console.WriteLine("Enter an amount to deposit into your account.");
            double depositAmount = double.Parse(Console.ReadLine());

            a.Deposit(depositAmount);
            double userBalance = a.GetBalance();

            Console.WriteLine($"Your currant account balance is: {userBalance, 0:c}");
        }
    }
}
