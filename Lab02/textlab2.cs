using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB.Lab02
{
    public class textlab2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("array");
            int[] soNguyen = [5, 4, 1, 3, 2, 4];
            int FindIndex = Array.IndexOf(soNguyen, 1);
            System.Console.WriteLine(FindIndex);
            soNguyen.Sort();
            System.Console.Write($"{string.Join(",", soNguyen)}");

            System.Console.WriteLine();
            string[] monhoc = ["toan", "li", "hoa", "van"];
            Array.Find(monhoc, x => x == "li");//Array.Find hamtimkiem
            string[]? FindAlll = Array.FindAll(monhoc, x => x.StartsWith("h"));
            foreach (string i in FindAlll)
            {
                System.Console.WriteLine($"{i}");
            }
            //            bool FindCheck=Array.Exists(monhoc=>x=>x=="hoa");

        }
    }
}