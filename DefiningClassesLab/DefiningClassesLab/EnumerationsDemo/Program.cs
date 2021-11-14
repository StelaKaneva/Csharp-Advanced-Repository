using System;

namespace EnumerationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Payment payment = Payment.Bank;
            Console.WriteLine(payment);
            DoPayment(Payment.Cash);
            DoPayment(Payment.GoToCanada);

            Console.WriteLine($"Cash: {(int)Payment.Cash}");
            Console.WriteLine($"4: {(Payment)4}");
        }

        static void DoPayment(Payment type)
        {
            if (type == Payment.Cash)
            {
                Console.WriteLine("Take all the money");
            }
            else if (type == Payment.GoToCanada)
            {
                Console.WriteLine("Forget the money");
            }
            else
            {
                Console.WriteLine(type);
            }
        }
    }
}
