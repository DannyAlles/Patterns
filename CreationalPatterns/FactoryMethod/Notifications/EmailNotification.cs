using CreationalPatterns.FactoryMethod.Abstractions;
using CreationalPatterns.FactoryMethod.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.Notifications
{
    public class EmailNotification : INotification
    {
        public string Message { get; set; }

        public NotificationResponse Send()
        {
            return new()
            {
                Point = "Email",
                Message = Message,
            };
        }
    }
}
