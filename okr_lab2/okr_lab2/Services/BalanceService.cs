using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okr_lab2.Services   // або де він у тебе лежить
{
    public class BalanceService   // ← ДОДАЙ public!
    {
        private double balance = 0;   // поле може бути private — це ок

        public BalanceService()       // ← ДОДАЙ public конструктор!
        {
        }

        public void AddFunds(double amount)   // ← public!
        {
            if (amount <= 0)
                throw new ArgumentException("Сума має бути більше нуля");
            balance += amount;
        }

        public double Balance => balance;     // ← public властивість (або з get)
        // або так:
        // public double Balance { get { return balance; } }
    }
}