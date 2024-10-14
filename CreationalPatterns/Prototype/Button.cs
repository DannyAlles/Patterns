using CreationalPatterns.Prototype.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Prototype
{
    public class Button : IButtonPrototype
    {
        public ConsoleColor Color { get; set; }
        public string Text { get; set; }
        public char Border { get; set; }

        public Button(ConsoleColor color, string text, char border)
        {
            this.Color = color;
            this.Text = text;
            this.Border = border;
        }

        public Button(IButtonPrototype button)
        {
            this.Color = button.Color;
            this.Text = button.Text;
            this.Border = button.Border;
        }

        public void Print()
        {
            Console.ForegroundColor = this.Color;

            Console.WriteLine();
            Console.WriteLine(new string(this.Border, (this.Text?.Length ?? 8) + 16));
            Console.WriteLine($"\t{this.Text}");
            Console.WriteLine(new string(this.Border, (this.Text?.Length ?? 8) + 16));
            Console.WriteLine();

            Console.ResetColor();
        }

        public IButtonPrototype Clone()
        {
            StringBuilder text = new StringBuilder(this.Text);
            text.Append(" Clone");

            var clone = (Button)this.MemberwiseClone();

            clone.Color = this.Color;
            clone.Text = text.ToString();
            clone.Border = this.Border;

            return clone;
        }
    }
}
