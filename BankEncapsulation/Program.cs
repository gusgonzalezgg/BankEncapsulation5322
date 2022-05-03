using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount currentBalance = new BankAccount();
            
            Console.WriteLine("How much would you like to deposit today?" );

            var amount = double.Parse(Console.ReadLine());

            currentBalance.Deposit(amount);

            var balance = currentBalance.GetBalance();

            Console.WriteLine(balance);

        }
    }
}
