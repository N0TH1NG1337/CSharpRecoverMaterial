using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial
{
    internal class New_Things
    {

        //Some material that I dont remember that we learned

        // Static functions and vars
        /*
            Most of the time when we created a function we used static keyword.
            `is used to declare members that belong to the type itself rather than to a specific object. 
            This means that only one copy of the member exists, regardless of how many objects are created from the type`

            Note ! 'Static members can be classes, variables, methods, constructors, properties, events, and operators'

            Good example will be when we create a class,
            we can create a static proporty.
            For Example :
            
                class Man {
                    public static string Type = "humen";

                    ...
                }

            the `static` in the property mean that this value is referring to all the objects
            from the class Man

            what does this mean ? 
            to access it we dont type the name of the object
            we using the class name to access it (if we set it to public, otherwise it will be a little bit different)
            Man.Type // "humen"
         */

        // Class Inheritance
        /*
            Class Inheritance is when one class works like the main class and other classes take / use, the same methods / things from the main class

            For Example :
                class Human {
                    public string Name = "...";
                    public int Age = ...;

                    ... other things in class
                }

                class Man : Human {
                    public bool HasBeard = ...;

                    ... other things in class
                }

                // When we create Man type object 
                Man First = new Man(...);

                First.Name; 
                // we can access things from Humen class too (like data , functions [in most cases] and more)

            Note ! also possible to use like different proporty in the Man class that it will be Humen type,
            also possible, and from there to access data
         */

    }
}
