using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.FactoryMethod.Abstractions.Interfaces
{
    public interface INotification
    {
        public string Message { get; set; }
        public NotificationResponse Send();
    }
}
