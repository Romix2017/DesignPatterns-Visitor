﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
        public void OperationA()
        {
        }
    }
}
