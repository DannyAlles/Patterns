using CreationalPatterns.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Lines
{
    public class HashLine : BaseLine
    {
        public override string Print()
        {
            return "\n=======================\n";
        }
    }
}
