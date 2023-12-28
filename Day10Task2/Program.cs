using System;
using System.ComponentModel.DataAnnotations;

namespace Day10Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathOperator(4,3.3,'*')); // Task 1
            Console.WriteLine(CountChar("Zaur Memmedov", 'e')); // Task 2
            Console.WriteLine(CountWords("  Code ACademy  ")); // Task 3
            Console.WriteLine(SumNumber(4567)); // Task 4
            Console.WriteLine(PowerOfNum(4,4)); // Task 5
            Console.WriteLine(PositiveArr(new int[] {-2,3,6,-9,0})); // Task 6
            Console.WriteLine(ReversedString("salam")); // Task 7

        }

        // 1. Verilmiş iki ədəd üzərində verilmiş operator simvoluna
        // əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.

        static int MathOperator(int num1, int num2, char opr)  
        {
            int result = 0;
                switch (opr)
                {
                    case '+':
                        result = num1 + num2;
                    break;
                    case '-':
                        result = num1 - num2;
                    break;
                    case '*':
                        result = num1 * num2;
                    break;
                    case '/':
                    if(num2!=0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("0-a bolme var!");
                    break;
                    case '%':
                        result = num1 % num2;
                    break;
                    default:
                    Console.WriteLine("Emeliyyat yanlisdir!");
                    break;
                }
            return result;
        }


        static double MathOperator(double num1, double num2, char opr)
        {
            double result = 0;
            switch (opr)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("0-a bolme var!");
                break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Emeliyyat yanlisdir!");
                    break;
            }
            return result;
        }


        // 2. Verilmiş yazıdaki verilmiş simvolların sayını qaytaran metod

        static int CountChar(string str, char chr)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    count++;
                }
            }
            return count;
        }

        // 3. Verilmiş yazıdaki sözlərin sayını qaytaran metod (söz dedikdə boşluqlarla ayrılmış bütün yazılar nəzərdə tutulur)

        static int CountWords(string str)
        {
            int count = 0;
            bool check = false;
            for(int i = 0;i < str.Length;i++)
            {
                if (str[i] == ' ')
                {
                    if (check)
                    {
                        count++;
                        check = false;
                    }
                }
                else
                {
                    check = true;
                }
            }
            if (check)
            {
                count++;
            }
            return count;
            
        }

        // 4. Verilmişdədin rəqəmləri cəmini qaytaran metod

        static int SumNumber(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        // 5. Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod

        static int PowerOfNum(int num, int power)
        {
            int result = 1;
            for(int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }

        // 6. Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod.
        // Misalçün  metoda {1,-4,9,-8} dəyərləri olan array göndərilsə metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.

        static int[] PositiveArr(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr[i] = arr[i];
                }
                else
                {
                    newArr[i] = arr[i] * (-1);
                }
            }
            return newArr;
        }

        // 7. Verilmiş yazını tərs formada qaytaran metod
        // (Misalçün "salam" göndərilsə metoddan "malas" return ediləcək)

        static string ReversedString(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1;i >= 0;i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
