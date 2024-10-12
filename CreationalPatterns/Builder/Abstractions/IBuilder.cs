using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder.Abstractions
{
    public interface IBuilder
    {
        public Button SetBorder(char border);
        public Button SetColor(ConsoleColor color);
        public Button SetText(string text);
        public Button GetResult();
        public void Reset();
    }
}
