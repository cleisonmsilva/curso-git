using System;
using Estudo.Entities;
using Estudo.Entities.Enums;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            
            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}