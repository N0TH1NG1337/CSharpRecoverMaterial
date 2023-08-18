using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial.Loops
{
    internal class ForLoops
    {
        /*
            For loops
            (Number Loops)

            Create one :
            
                for (int/double _name = [start index]; Bool_State (if true, next); Jumps) {
                    
                    // Note ! (קפיצות ; מטרה ; ערך התחלתי )
                    // the bool state can be everything to check like if statement
                    // Also usage of the _name can be accessed only in block if created in the [for] lone 
                }

            Types of jumps :
            _name++ | _name = _name + 1
            _name-- | _name = _name _ 1
            _name = _name (type, +, -, ...)
            
         */

        void Example()
        {
            // Example of simple loop
            // Will print all numbers from 0 to 10
            for (int Index = 0; Index < 11; Index++)
            {
                Console.WriteLine(Index); 
                // Note ! Since we check if the number is < 11 then if it is 11
                // then it wont enter the next run of the loop block (it will exit)
            }
        }
    }
}
