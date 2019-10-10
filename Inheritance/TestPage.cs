using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Inheritance
{
    public class TestPage : ActionClass
    {

        public void ClickAddButton()
        {
            ClickElement(new object());
        }

        public void SetText(string text) => SetText(new object(), text);

        public bool CheckIfListContainsAtLeastOneElement()
        {
           return  FindElementsBy(new object()).Count > 0 ? true : false;
        }

        public string GetElementFromPopUp => FindElement(new object()).ToString();

        
    }
}
