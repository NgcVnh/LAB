using Lab03.bin;

namespace System;
class Program
{
    static void Main(string[] args)
    {
        SavingsAccount s1 = new SavingsAccount("001", "Vinh", 10000, 5);
        s1.Deposit(2000);

        s1.CalculateInterest();

        s1.Display();
    }
}