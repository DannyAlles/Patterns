using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype.Interfaces
{
    public interface IButtonPrototype
    {
        public ConsoleColor Color { get; set; }
        public string Text { get; set; }
        public char Border { get; set; }

        public void Print();
        public IButtonPrototype Clone();
    }
}
