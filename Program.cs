using System;
using EnumCsharp.Entities;
using EnumCsharp.Entities.Enums;

namespace EnumCsharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Order order = new Order {
        Id = 1080,
        Moment = DateTime.Now,
        Status = OrderStatus.PendingPayment
      };

      Console.WriteLine(order);

      //coverter enum para string
      string txt = OrderStatus.PendingPayment.ToString();
      Console.WriteLine("string: " +txt);

      //converter string para enum
      OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
      Console.WriteLine("enum: " +os);
    }
  }
}