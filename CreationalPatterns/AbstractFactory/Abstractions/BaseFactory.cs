using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Abstractions
{
    public abstract class BaseFactory
    {
        public abstract BaseButton CreateButton();
        public abstract BaseLine CreateLine();
    }
}
