using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1App
{
    class Program
    {
        private static void Task1()
        {
            int var1 = 782130;
            sbyte var2 = -15;
            int var3 = 48258542;
            byte var4 = 0;
            short var5 = -10000;
            int var6 = 782130;
            int var7 = -95543;
            int var8 = 962482;
            uint var9 = 2244230;
            long var10 = 23474326891;
        }

        private static void Task2()
        {
            Console.WriteLine("-- Task 2 --");
            double var1 = 34.567839023;
            float var2 = 12.345f;
            double var3 = 8923.1234857;
            float var4 = 3456.091f;

            Console.WriteLine(var1);
            Console.WriteLine(var2);
            Console.WriteLine(var3);
            Console.WriteLine(var4);

        }

        private static void Task3()
        {
            Console.WriteLine("-- Task 3 --");
            char unicode = '\u0021';
            Console.WriteLine("Unicode char \\u0021 - " + unicode);
        }

        private static void Task4()
        {
            Console.WriteLine("-- Task 4 --");
            bool isFemale = true;
            Console.WriteLine("isFemale - " + isFemale);
        }

        private static void Task5()
        {
            Console.WriteLine("-- Task 5 --");
            string str1 = "Hello";
            string str2 = "World";
            string str3 = str1 + ' ' + str2;
            Console.WriteLine(str3);
        }

        private static void Task6()
        {
            Console.WriteLine("-- Task 6 --");
            string str1 = "The \"use\" of quotations causes difficulties!";
            Console.WriteLine(str1);
        }

        private static void Task7()
        {
            Console.WriteLine("-- Task 7 --");
            string firstName = "Ivan";
            string lastName = "Kolev";
            short age = 47;
            string gender = "Male";
            long personalId = 8306112507;
            decimal employeeNumber = 123456789012345;

            Console.WriteLine("First Name - " + firstName);
            Console.WriteLine("Last Name - " + lastName);
            Console.WriteLine("Age - " + age);
            Console.WriteLine("Gender - " + gender);
            Console.WriteLine("Personal Id - " + personalId);
            Console.WriteLine("Employee Number - " + employeeNumber);
        }

        private static void Task8()
        {
            Console.WriteLine("-- Task 8 --");
            int a = 0;
            int b = 1;

            Console.WriteLine("a - " + a);
            Console.WriteLine("b - " + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a - " + a);
            Console.WriteLine("b - " + b);
        }

        private static void Task9()
        {
            Console.WriteLine("-- Task 9 --");
            string firstName = "Ivan";
            string middleName = "Stoyanov";
            string lastName = "Kolev";
            float balance = 1234.05f;
            string bankName = "FIBank";
            string IBAN = "BG0904FIBN345465465";
            string cardNumber1 = "089745673454454";
            string cardNumber2 = "089745673454454";
            string cardNumber3 = "089745673454454";
        }

        private static void Task10()
        {
            Console.WriteLine("-- Task 10 --");

            Console.Write("Please enter the age - ");
            String input = Console.ReadLine();
            int age = int.Parse(input);

            if(18 < age  && age < 80)
            {
                Console.WriteLine("Age is between 18 and 80 ");
            } else if(16 <= age && age <= 18)
            {
                Console.WriteLine("Age is between 16 and 18");
            }
        }

        private static void Task11()
        {
            Console.WriteLine("-- Task 11 --");

            Console.Write("Please enter your name - ");
            String name = Console.ReadLine();
            
            Console.WriteLine("Hello, {0}!", name);

        }

        private static void Task12()
        {
            Console.WriteLine("-- Task 12 --");

            Console.Write("Please enter the first number - ");
            String number = Console.ReadLine();
            int var1 = int.Parse(number);

            Console.Write("Please enter the second number - ");
            number = Console.ReadLine();
            int var2 = int.Parse(number);

            Console.Write("Please enter the third number - ");
            number = Console.ReadLine();
            int var3 = int.Parse(number);

            int max = GetMax(var1, var2);
            max = GetMax(max, var3);

            Console.WriteLine("The max number is -  {0}!", max);

        }

        private static int GetMax(int a, int b)
        {
            if(a > b)
            {
                return a;
            } else
            {
                return b;
            }
        }

        private static void Task13()
        {
            Console.WriteLine("-- Task 13 --");

            Console.Write("Please enter the number - ");
            String input = Console.ReadLine();
            int myNumber = int.Parse(input);

            string lastDigit = GetLastDigit(myNumber);
            Console.WriteLine("The last digit is - {0}!", lastDigit);
        }

        private static String GetLastDigit(int number)
        {
            int lastDigit = number % 10;

            switch(lastDigit)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                case 7:
                    return "Seven";
                case 8:
                    return "Eight";
                case 9:
                    return "Nine";

            }

            return "";
        }

        private static int CountNumber(int[] array, int number)
        {
            int count = 0;
            for(int idx = 0; idx < array.Length; ++idx)
            {
                if(array[idx] == number)
                {
                    ++count;
                }
            }

            return count;
        }

        private static void Task14()
        {
            Console.WriteLine("-- Task 13 --");

            int[] testArray = { 12, 3, 5, 7, 12, 11};

            int number = 12;
            int count = CountNumber(testArray, number);
            Console.WriteLine("The " + number + " appears " + count + " times! ");

            number = 3;
            count = CountNumber(testArray, 3);
            Console.WriteLine("The " + number + " appears " + count + " times! ");

            number = 1000;
            count = CountNumber(testArray, number);
            Console.WriteLine("The " + number + " appears " + count + " times! ");
        }

        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();
            Task5();
            Console.WriteLine();
            Task6();
            Console.WriteLine();
            Task7();
            Console.WriteLine();
            Task8();
            Console.WriteLine();
            Task9();
            Console.WriteLine();
            Task10();
            Console.WriteLine();
            Task11();
            Console.WriteLine();
            Task12();
            Console.WriteLine();
            Task13();
            Console.WriteLine();
            Task14();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
