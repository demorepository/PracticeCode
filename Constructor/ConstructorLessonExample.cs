using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleConstructor
{
    public class Product
    {
        public int Num = 2;
        public static int NumStat { get; set; }
        /// <summary>
        /// Static readonly variable that must be initialized at run time, which means:
        /// we can assign value on class level or in static constructor(!)
        /// Otherwise we cannot assign value to readOnly variable.
        /// </summary>
        static readonly long baseline;
        public Product()
        {
            Console.WriteLine("Invoke default constructor");
            //Now we changing value of variable Num,
            //after initialization Num will be 3.
            Num = 3;
        }

        /// <summary>
        /// It is called automatically before the first 
        /// instance is created or any static members are referenced.
        /// A static constructor will run before an instance constructor(!).
        /// </summary>
        static Product()
        {
            Console.WriteLine("Invoke static constructor");
            baseline = DateTime.Now.Ticks;
            NumStat = 4;
        }
        //important info about constructor:
        //static constructor runs only one time,
        // even though two instances of Product are created,
        //and that it runs before the instance constructor runs.

        //Parametrized construcotr
        /// <summary>
        /// Ex: var product = new Product(10);
        /// Console.WriteLine(product.Num) -> 10 
        /// instead of 3(which was set in default constructor)
        /// </summary>
        /// <param name="value"></param>
        public Product(int value)
        {
            Num = value;
        }

    }
}
