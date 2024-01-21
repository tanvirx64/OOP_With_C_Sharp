using System.Collections.Generic;

namespace Constractor
{
    internal partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            public List<Order> orders;

            public Customer()
            {
                this.orders = new List<Order>();
            }

            public Customer(int id)
                :this()
            {
                this.Id = id;
            }

            public Customer(int id, string name) 
                : this(id)
            {
                Name = name;
            }
        }
    }
}
