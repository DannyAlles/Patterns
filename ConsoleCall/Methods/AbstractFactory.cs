using CreationalPatterns.AbstractFactory;
using CreationalPatterns.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCall.Methods
{
    public class AbstractFactory
    {
        public void Factory(BaseFactory factory)
        {
            var button = factory.CreateButton();
            Console.WriteLine(button.Print());

            var line = factory.CreateLine();
            Console.WriteLine(line.Print());
        }
    }
}
