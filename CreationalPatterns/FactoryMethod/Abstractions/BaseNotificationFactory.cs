using CreationalPatterns.FactoryMethod.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.Abstractions
{
    public abstract class BaseNotificationFactory
    {
        public NotificationResponse SendNotification()
        {
            var notificatioon = CreateNotification();
            var result = notificatioon.Send();
            return result;
        }

        public abstract INotification CreateNotification();
    }
}
