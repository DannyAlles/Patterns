using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    public class Button
    {
        private ConsoleColor? color;
        private string? text;
        private char? border;

        public Button SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }

        public Button SetText(string text)
        {
            this.text = text;
            return this;
        }

        public Button SetBorder(char border)
        {
            this.border = border;
            return this;
        }

        public void Print()
        {
            if(this.color is not null) Console.ForegroundColor = this.color.Value;

            Console.WriteLine();
            if(this.border is not null) Console.WriteLine(new string(this.border.Value, (this.text?.Length ?? 8) + 16));
            Console.WriteLine($"\t{this.text}");
            if (this.border is not null) Console.WriteLine(new string(this.border.Value, (this.text?.Length ?? 8) + 16));
            Console.WriteLine();

            Console.ResetColor();
        }
    }
}
