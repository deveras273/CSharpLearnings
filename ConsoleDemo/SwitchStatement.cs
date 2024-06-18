/*Problem: ATM Withdrawal Simulator
Problem Statement
You are tasked with simulating an ATM (Automated Teller Machine) withdrawal process. Implement a program that:

Takes an integer input representing the withdrawal amount.
Calculates and prints the number of each type of banknotes (2000, 500, 200, 100) needed to complete the withdrawal using the minimum number of notes.
Requirements
Implement a method WithdrawMoney that:

Takes an int parameter amount representing the withdrawal amount.
Prints the number of each type of banknote required to fulfill the withdrawal.
Use the largest possible denominations first to minimize the number of banknotes used.
If the withdrawal amount cannot be completely fulfilled (e.g., due to insufficient notes), print an appropriate message.
Use a switch statement to handle different denominations of banknotes (2000, 500, 200, 100).

In the Main method:

Prompt the user to enter a withdrawal amount.
Call the WithdrawMoney method with the user input.*/



using System;

namespace ConsoleDemo
{
    
    class SwitchStatement
    {
        public void WithdrawMoney(int amount)
        {
            Console.WriteLine($"Withdrawal amount: {amount}");

            int remainingAmount = amount;

            Console.WriteLine("Banknotes:");
           
            switch (remainingAmount / 2000)
            {
                case int count when count > 0:
                    Console.WriteLine($"2000 : {count}");
                    remainingAmount %= 2000;
                    break;
            }

            switch (remainingAmount / 500)
            {
                case int count when count > 0:
                    Console.WriteLine($"500 : {count}");
                    remainingAmount %= 500;
                    break;
            }

            switch (remainingAmount / 200)
            {
                case int count when count > 0:
                    Console.WriteLine($"200 : {count}");
                    remainingAmount %= 200;
                    break;
            }

            switch (remainingAmount / 100)
            {
                case int count when count > 0:
                    Console.WriteLine($"100 : {count}");
                    remainingAmount %= 100;
                    break;
            }

            if (remainingAmount > 0)
            {
                Console.WriteLine("Insufficient banknotes to fulfill the withdrawal amount.");
            }

        }
        static void Main()
        {
            SwitchStatement switchStatement = new SwitchStatement();
            Console.WriteLine("Enter the amount you want to withdraw");
            bool flag = int.TryParse(Console.ReadLine(), out int amountRequired);
            if (flag)
            {
               switchStatement.WithdrawMoney(amountRequired);
            }
            else
            {
                Console.WriteLine("The input number is invalid");
            }
        }
    }
}