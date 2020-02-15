using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorRealWorld
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
