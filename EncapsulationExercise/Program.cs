using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much money would you like to deposit?");
            double amounToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amounToDeposit);
            double userbalance = ba.GetBalance();

            Console.WriteLine($"Your current balance is: {userbalance,0:c}");

        }

    }
}

