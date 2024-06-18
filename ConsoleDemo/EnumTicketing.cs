using System;

namespace ConsoleDemo
{
    enum TicketType
    {
        Child,
        Adult,
        Senior,
        Student
    }
    class TicketManager
    {
        public static decimal GetTicketPrice(TicketType ticketType )
        {
            if (ticketType == TicketType.Child)
            {
                return 5.00m;
            }
            else if (ticketType == TicketType.Student)
            {
                return 8.00m;
            }
            else if (ticketType == TicketType.Adult)
            {
                return 10.00m;
            }
            else
            {
                return 7.00m;
            }
        }

    }
    class EnumTicketing
    {


        static void Main()
        {
            Console.WriteLine("Enter the ticket type (0: Child, 1: Adult, 2: Senior, 3: Student):");
            bool flag = int.TryParse(Console.ReadLine(), out int ticketTypeNumber);
            if (flag)
            {
                if (Enum.IsDefined(typeof(TicketType), ticketTypeNumber))
                {
                    TicketType selectedTicketType = (TicketType)ticketTypeNumber;
                    decimal price = TicketManager.GetTicketPrice(selectedTicketType);
                    Console.WriteLine($"The ticket price is {price}");
                }
                else
                {
                    Console.WriteLine("The number enter is invalid! Please enter a valid number");
                }
            }
        }
    }
}