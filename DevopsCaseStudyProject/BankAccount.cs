using System;

namespace DevopsCaseStudyDemoProject
{
    public class BankAccount
    {
        string _customerName;
        double _balance;

        public BankAccount(string customerName, double amount)
        {
            _customerName = customerName;
            _balance = amount;
        }

        public double Balance { get { return _balance; } }

        public void Debit(double amount)
        {
            if (_balance == 0)
                throw new Exception("Balance is 0");
            if (amount <= 0 || amount > _balance)
                throw new ArgumentOutOfRangeException("Amount = 0 or Amount > Balance");
            _balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Amount <= 0");
            _balance += amount;
        }
    }
}