using CreationalPatterns.FactoryMethod.Abstractions;
using CreationalPatterns.FactoryMethod.Abstractions.Interfaces;
using CreationalPatterns.FactoryMethod.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.Factories
{
    public class EmailNotificationFactory : BaseNotificationFactory
    {
        private string _message { get; set; }

        public EmailNotificationFactory(string message)
        {
            _message = message;
        }

        public override INotification CreateNotification()
        {
            return new EmailNotification()
            {
                Message = _message,
            };
        }
    }
}
