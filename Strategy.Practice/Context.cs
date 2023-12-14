using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Practice
{
    internal class Context
    {
        private INotificationService _strategy;

        public Context(INotificationService strategy)
        {
            _strategy = strategy;
        }

        public void Operation()
        {
            Console.WriteLine("Starting choosing algorithm");
            _strategy.SendNotification();
        }
    }
}
