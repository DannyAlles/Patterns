using CreationalPatterns.Builder;
using CreationalPatterns.Builder.Builders;
using CreationalPatterns.FactoryMethod.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCall.Methods
{
    public class Builder
    {
        public void Factory()
        {
            var builder = new ButtonBuilder();
            builder.SetText("Button text").SetBorder('=').SetColor(ConsoleColor.Red); 

            builder.GetResult().Print();

            var director = new ButtonDirector
            {
                Builder = builder
            };

            director.SetDefaultButton();
            builder.GetResult().Print();

            director.SetWithoutBorder();
            builder.GetResult().Print();

            director.SetWithoutText();
            builder.GetResult().Print();
        }
    }
}
