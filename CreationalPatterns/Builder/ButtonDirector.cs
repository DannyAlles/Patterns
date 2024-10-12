using CreationalPatterns.Builder.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    public class ButtonDirector
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void SetDefaultButton()
        {
            _builder.SetText("Director").SetBorder('#').SetColor(ConsoleColor.White);
        }

        public void SetWithoutText()
        {
            _builder.SetBorder('#').SetColor(ConsoleColor.Cyan);
        }

        public void SetWithoutBorder()
        {
            _builder.SetText("Without border").SetColor(ConsoleColor.DarkYellow);
        }
    }
}
