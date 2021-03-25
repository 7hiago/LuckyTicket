using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your \"Lucky ticket\"");
                var value1 = 0;
                var value2 = 0;
                var number = 0;
                var ticket = Console.ReadLine();
                if (ticket[0] == '+' || !Int32.TryParse(ticket, out number) || (number < 1000 || number > 99999999))
                {
                    Console.WriteLine("Your ticket format is wrong, try again!");
                    continue;
                }
                if (ticket.Length % 2 == 1)
                {
                    ticket = String.Join("", "0", ticket);
                }
                for (var i = 0; i < ticket.Length; i++)
                {
                    if (i < ticket.Length / 2)
                    {
                        value1 += Convert.ToInt32(Char.GetNumericValue(ticket[i]));
                    }
                    else
                    {
                        value2 += Convert.ToInt32(Char.GetNumericValue(ticket[i]));
                    }
                }
                if (value1 == value2)
                {
                    Console.WriteLine("Congratulations! You have a \"Lucky ticket\"");
                }
                else
                {
                    Console.WriteLine("Maybe next time, luck will be on your side.");
                }
            }
        }
    }
}
