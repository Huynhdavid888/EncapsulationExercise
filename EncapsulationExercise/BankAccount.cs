using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExercise
{
    public class BankAccount
    {
        private  double _balance;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount,0:c} your account!");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
