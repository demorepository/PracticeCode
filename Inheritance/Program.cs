using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Inheritance
{
    class Program
    {
        static void Main()
        {
            // Create an instance of WorkItem by using the constructor in the 
            // base class that takes three arguments.
            WorkItemObject item = new WorkItemObject("Fix Bugs",
                                         "Fix all bugs in my code branch",
                                         new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            ChangeRequestAction change = new ChangeRequestAction("Change Base Class Design",
                                                     "Add members to the class",
                                                     new TimeSpan(4, 0, 0),
                                                     1);

            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the 
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",
                new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
