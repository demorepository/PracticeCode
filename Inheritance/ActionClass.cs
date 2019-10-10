using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Inheritance
{
    //why abstract? if you dont want to instantiate class then make it abstract.
    public abstract class ActionClass
    {




        protected void ClickElement(object locator)
        {
            //not implemented
        }

        protected void SetText(object locator, string text)
        {
            //not implemented
        }


        protected object FindElement(object locator)
        {
            throw new NotImplementedException();
        }

        protected IReadOnlyCollection<object> FindElementsBy(object locator)
        {
            throw new NotImplementedException();
        } 
    }
}
