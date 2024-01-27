using System;

namespace EventsAndDelegates
{
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
}
