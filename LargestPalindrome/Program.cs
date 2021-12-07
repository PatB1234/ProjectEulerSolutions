using System;

class Program
{
    public static void Main(string[] args)
    {

        int biggerNum = 0;
        for (int num = 1000; num < 998001; num++)
        {

            if (isPalindrome(num))
            {

                for (int i = 100; i <= 999; i++)
                {

                    if (num % i == 0 && ((num / i) > 100) && ((num / i) < 999) && num > biggerNum)
                    {

                        biggerNum = num;
                    }
                }
            }
            else
            {

                continue;
            }

        }

        Console.WriteLine(biggerNum);
    }

    public static bool isPalindrome(int num)
    {

        int number = num;
        int reverse = 0;
        while (number != 0)
        {

            int remainder = number % 10;
            reverse = (reverse * 10) + remainder;
            number = number / 10;
        }

        if (reverse == num)
        {

            return true;
        }
        else
        {

            return false;
        }
    }
}