using CreationalPatterns.FactoryMethod.Abstractions;
using CreationalPatterns.FactoryMethod.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCall.Methods
{
    public class FactoryMethod
    {
        public void Factory(BaseNotificationFactory notification)
        {
            var response = notification.SendNotification();

            Console.WriteLine();
            Console.WriteLine($"Фабрика: {response.Point}\nСообщение: {response.Message}");
            Console.WriteLine();
        }
    }
}
