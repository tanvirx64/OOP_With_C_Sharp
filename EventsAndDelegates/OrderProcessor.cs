using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class OrderProcessor
    {
        public event EventHandler<OrderEventArgs> OrderPlaced;

        public void PlaceOrder(Order order)
        {
            Console.WriteLine("Placing your order");
            Thread.Sleep(3000);

            OnOrderPlaced(order);
        }

        protected void OnOrderPlaced(Order order)
        {
            if (OrderPlaced != null)
                OrderPlaced(this, new OrderEventArgs() { Order = order });
        }
    }
}
