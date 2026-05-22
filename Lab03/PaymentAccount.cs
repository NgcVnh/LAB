using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB.Lab03
{
    // Class tài khoản thanh toán
    public abstract class PaymentAccount
    {
        // Thuộc tính
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public double Balance { get; set; }

        // Constructor
        public PaymentAccount(string accountNumber,
                              string ownerName,
                              double balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        // Nạp tiền
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Đã nạp {amount}");
        }

        // Rút tiền
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Đã rút {amount}");
            }
            else
            {
                Console.WriteLine("Không đủ tiền!");
            }
        }

        // Hiển thị thông tin
        public virtual void Display()
        {
            Console.WriteLine("=== PAYMENT ACCOUNT ===");
            Console.WriteLine($"Số TK: {AccountNumber}");
            Console.WriteLine($"Chủ TK: {OwnerName}");
            Console.WriteLine($"Số dư: {Balance}");
        }
    }
}
