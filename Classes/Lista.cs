using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //pode ser declarado dessa forma
        //     // IList<Payment> payments = new List<Payment>();
        //     // payments.Remove(new Payment());
        //     //pode ser declarado dessa forma ficando igual a payments
        //     var payments = new List<Payment>();
        //     payments.Add(new Payment(1));
        //     payments.Add(new Payment(2));
        //     payments.Add(new Payment(3));
        //     payments.Add(new Payment(4));

        //     foreach (var payment in payments)
        //     {
        //         Console.WriteLine(payment.Id);
        //     }

        // }

    }
    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }

}