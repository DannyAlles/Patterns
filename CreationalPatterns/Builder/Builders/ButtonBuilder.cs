using CreationalPatterns.Builder.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder.Builders
{
    public class ButtonBuilder : IBuilder
    {
        private Button button = new();

        public Button GetResult()
        {
            var result = this.button;
            this.Reset();
            return result;
        }

        public Button SetText(string text)
        {
            button.SetText(text);
            return button;
        }

        public Button SetColor(ConsoleColor color)
        {
            button.SetColor(color);
            return button;
        }

        public Button SetBorder(char border)
        {
            button.SetBorder(border);
            return button;
        }

        public void Reset()
        {
            button = new();
        }
    }
}
