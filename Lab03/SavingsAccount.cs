using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB.Lab03;

namespace Lab03.bin
{
    // Class tài khoản tiết kiệm
    public class SavingsAccount : PaymentAccount
    {
        // Thuộc tính riêng
        public double InterestRate { get; set; }

        // Constructor class con
        public SavingsAccount(string accountNumber,
                              string ownerName,
                              double balance,
                              double interestRate)
            : base(accountNumber, ownerName, balance)
        {
            InterestRate = interestRate;
        }

        // Hàm tính lãi
        public void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Balance += interest;

            Console.WriteLine($"Tiền lãi: {interest}");
        }

        // Override method Display
        public override void Display()
        {
            base.Display();

            Console.WriteLine($"Lãi suất: {InterestRate}%");
        }
    }
}