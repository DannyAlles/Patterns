using CreationalPatterns.FactoryMethod.Abstractions;
using CreationalPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCall.Methods
{
    class Prototype
    {
        public void Factory()
        {
            var button = new Button(ConsoleColor.Red, "Button 1", '#');
            ButtonPrototypeRegistry prototypeRegistry = new();
            prototypeRegistry.AddButton(button);
            prototypeRegistry.AddButton(new Button(ConsoleColor.Blue, "Button 2", '#'));

            var clone = button.Clone();
            prototypeRegistry.AddButton(clone);

            var buttonByColor = prototypeRegistry.GetByColor(ConsoleColor.Blue);
            prototypeRegistry.AddButton(buttonByColor);

            prototypeRegistry.Print();
        }
    }
}
