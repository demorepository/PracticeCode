using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Inheritance
{
    class ImportantInfo
    {
        //Inheritance enables you to create new classes that reuse, extend, 
        //and modify the behavior that is defined in other classes.The class
        //whose members are inherited is called the base class, and the class
        //that inherits those members is called the derived class. A derived 
        //class can have only one direct base class. However, inheritance is transitive.
        //If ClassC is derived from ClassB, and ClassB is derived from ClassA,
        //ClassC inherits the members declared in ClassB and ClassA.

        //Inheritance enables you to create new classes that reuse, extend,
        //and modify the behavior that is defined in other classes.
        //The class whose members are inherited is called the base class,
        //and the class that inherits those members is called the derived class.
        //A derived class can have only one direct base class. However,
        //inheritance is transitive.If ClassC is derived from ClassB,
        //and ClassB is derived from ClassA, ClassC inherits the members 
        //declared in ClassB and ClassA.

        //When you define a class to derive from another class, 
        //the derived class implicitly gains all the members of the base class
        //except for its constructors and finalizers.The derived class can thereby
        //reuse the code in the base class without having to re-implement it.
        //In the derived class, you can add more members.In this manner, 
        //the derived class extends the functionality of the base class.


        //Abstract and Virtual Methods
        //When a base class declares a method as virtual, a derived class can override
        //the method with its own implementation.If a base class declares a member 
        //as abstract, that method must be overridden in any non-abstract class that
        //directly inherits from that class. If a derived class is itself abstract, 
        //it inherits abstract members without implementing them.Abstract and virtual
        //members are the basis for polymorphism, which is the second primary 
        //characteristic of object-oriented programming.For more information - check Polymorphism.

  
         //Abstract Base Classes
         //You can declare a class as abstract if you want to prevent direct instantiation by
         //using the new operator. If you do this, the class can be used only if a new class is 
         //derived from it.An abstract class can contain one or more method signatures that themselves
         //are declared as abstract. These signatures specify the parameters and return value but have no 
         //implementation(method body). An abstract class does not have to contain abstract members; however,
         //if a class does contain an abstract member, the class itself must be declared as abstract. 
         //Derived classes that are not abstract themselves must provide the implementation for any abstract
         //methods from an abstract base class.

    }
}
