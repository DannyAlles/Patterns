﻿using CreationalPatterns.AbstractFactory.Abstractions;
using CreationalPatterns.AbstractFactory.Buttons;
using CreationalPatterns.AbstractFactory.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory.Factories
{
    public class PlusFactory : BaseFactory
    {
        public override BaseButton CreateButton()
        {
            return new PlusButton();
        }

        public override BaseLine CreateLine()
        {
            return new PlusLine();
        }
    }
}
