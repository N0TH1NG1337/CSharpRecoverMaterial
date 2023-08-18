using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial.Strings
{
    internal class GeneralString
    {
        // String are complicated subject (however it is easy to understand)
        // SelfNote ! dont play to much with string 

        /*
            String 
            (array of chars)

            Create one:
                [option 1]
                string Name = ""; // Create empty string
                
                [option 2] 
                string Name = "..."; // Enter something

                [option 3]
                string Name; // ! Value of name is null

                
            Access the chars
            Name[Index] -> (from 0 to Length - 1)

            to obtain the char use var type char
            [Note ! Cannot modify the chars themselfs as array]
            char FirstLatter = Name[0];
        */

        void Example() {
            string Name = "Max"; // create new string var

            char FirstL = Name[0];
            char LastL = Name[Name.Length - 1]; // access the last char in the string

            string Input = Console.ReadLine(); // .ReadLine returns string
            Console.WriteLine(Input);
        }
    }
}
