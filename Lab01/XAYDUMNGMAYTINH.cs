using System;

namespace LAB.Lab01;

public class XAYDUNGMAYTINH
{
    //ham doc du lieu nhap vao kiem tra so nguyen 
    static bool TryReadInt(string prompt, out int result)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine() ?? "0";
        return int.TryParse(input, out result);
    }

//ham tinh va hien thi ket qua phep tinh
    static void PrintFinalEquation(int n1, int n2, int result, string
@operator)
    {
        if (@operator == "+")
        {
            result = n1 + n2;
            System.Console.WriteLine($"{n1}{@operator}{n2}= {result}");
        }

        else if (@operator == "-")
        {
            result = n1 - n2;
            System.Console.WriteLine($"{n1}{@operator}{n2}= {result}");
        }

        else if (@operator == "*")
        {
            result = n1 * n2;
            System.Console.WriteLine($"{n1} {@operator} {n2} = {result}");
        }

        else if (@operator == "/")
        {
            if (n1 % n2 == 0)
            {
                result = n1 / n2;
                System.Console.WriteLine($"{n1} {@operator} {n2} = {result}");
            }
            else if (n1 % n2 != 0)
            {
                double resultt = 0;
                resultt = n1 * 1.0 / n2;
                System.Console.WriteLine($"{n1} {@operator} {n2} = {resultt}");
            }
            else
                System.Console.WriteLine("khong the chia cho 0!");
        }
        else System.Console.WriteLine("khong hop le");
    }
    // static void Main(string[] args)
    // {
    //     System.Console.WriteLine("-------------------------------------------------------------------------------");
    //     if (!TryReadInt("Nhap so thu nhat:", out int num1))
    //     {
    //         System.Console.WriteLine("GIA TRI NHAP VAO KHONG PHAI SO NGUYEN");
    //         return;
    //     }
    //     if (!TryReadInt("Nhap so thu hai:", out int num2))
    //     {
    //         System.Console.WriteLine("GIA TRI NHAP VAO KHONG PHAI SO NGUYEN");
    //         return;
    //     }

    //     int result = 0;
    //     System.Console.WriteLine("Moi ban chon phep tinh: \n [A]dd numbers \n [S]ubtract numbers \n [M]utiply numbers \n [D]ive number");

    //     var choice = Console.ReadLine();

    //     switch (choice)
    //     {
    //         case "A":
    //             PrintFinalEquation(num1, num2, result, "+");
    //             break;
    //         case "S":
    //             PrintFinalEquation(num1, num2, result, "-");
    //             break;
    //         case "M":
    //             PrintFinalEquation(num1, num2, result, "*");
    //             break;
    //         case "D":
    //             PrintFinalEquation(num1, num2, result, "/");
    //             break;
    //         case "a":
    //             PrintFinalEquation(num1, num2, result, "+");
    //             break;
    //         case "s":
    //             PrintFinalEquation(num1, num2, result, "-");
    //             break;
    //         case "m":
    //             PrintFinalEquation(num1, num2, result, "*");
    //             break;
    //         case "d":
    //             PrintFinalEquation(num1, num2, result, "/");
    //             break;
    //         default:
    //             System.Console.WriteLine("lua chon khong hop le!");
    //             break;
    //     }
    //     System.Console.WriteLine("-------------------------------------------------------------------------------");
    //     Console.ReadKey();
    //
    }

