using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CakeShop store = new CakeShop();
            store.DayOrders();
        }
    }
}
