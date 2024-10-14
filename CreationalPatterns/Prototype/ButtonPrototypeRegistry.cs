using CreationalPatterns.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    public class ButtonPrototypeRegistry
    {
        List<IButtonPrototype> buttons = new List<IButtonPrototype>();

        public void AddButton(IButtonPrototype button)
        {
            buttons.Add(button);
        }

        public IButtonPrototype GetByColor(ConsoleColor color)
        {
            var button = buttons.FirstOrDefault(x => x.Color == color) ?? throw new ArgumentNullException();
            return button.Clone();
        }

        public void Print()
        {
            for (var i = 0; i < buttons.Count; i++) 
            {
                Console.WriteLine($"{i + 1})");
                buttons[i].Print();
            }
        }
    }
}
