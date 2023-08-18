using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial.Loops
{
    internal class WhileLoops
    {
        /*
            While Loops
            (Boolian Statement loops) "will work unless false statement"

            Create one :

                [option 1]
                while (Bool State) {
                    // Code
                }

                [option 2] : the second option will run the block 1 time and only then check in while to continiue or not
                do {
                    // Code
                } while (Bool State)

                WARNING !!! in while loops you always need to check that you have a exit at some point 
                otherwise the program will be stack in the loop and cause a crash in the end.

                
         */

        void Example()
        {
            // Create a numbe to check in the while loop
            int Number = 12;

            while (Number > 0)
            {
                Console.WriteLine(Number);
                Number--; // Number -= 1; // Number = Number - 1
            }

            // As soon as the number will reach 0. the loop will end
            // And go to the next line 
        }
    }
}
