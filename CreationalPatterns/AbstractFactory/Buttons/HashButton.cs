using CreationalPatterns.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Buttons
{
    public class HashButton : BaseButton
    {
        public override string Print()
        {
            return "\n======================\n" +
                   "\tButton" +
                   "\n======================\n";
        }
    }
}
