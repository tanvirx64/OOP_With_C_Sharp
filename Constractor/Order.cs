using System;

namespace Constractor
{
    internal partial class Program
    {
        public class Order
        {
            public int orderId;
            public int[] goodsId;
            public string address;
            public DateTime orderDate;
            public decimal totalAmount;
        }
    }
}
