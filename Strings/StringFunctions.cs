using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial.Strings
{
    internal class StringFunctions
    {
        // String functions are most powerful thing about string in coding
        // Note ! All the string functions called by the name of string var and dot like Name.function()

        // String Length
        // Name.Length | will return the amount of chars in the string

        // ! Clone()
        // Make clone of string.

        // CompareTo(string)
        // Compare two strings and returns integer value as output. It returns 0 for true and 1 for false.

        // Contains(char / string)
        // The C# Contains method checks whether specified character or string is exists or not in the string value.
        // Can use also char and string as args

        // ! EndsWith(char)
        // This EndsWith Method checks whether specified character is the last character of string or not.

        // Equals(string)
        // The Equals Method in C# compares two string and returns Boolean value as output.

        void Examples()
        {
            string firstname;
            string lastname;

            firstname = "Steven Clark";
            lastname = "Clark";

            // Make String Clone
            Console.WriteLine(firstname.Clone()); // : Steven Clark

            //Compare two string value and returns 0 for true and 1 for false
            Console.WriteLine(firstname.CompareTo(lastname)); // : 1

            //Check whether specified value exists or not in string
            Console.WriteLine(firstname.Contains("ven")); // : True

            //Check whether specified value is the last character of string
            Console.WriteLine(firstname.EndsWith("n")); // : False

            //Compare two string and returns true and false
            Console.WriteLine(firstname.Equals(lastname)); // : False

            //Returns HashCode of String
            Console.WriteLine(firstname.GetHashCode()); // : 1470518261

            //Returns type of string
            Console.WriteLine(firstname.GetType()); // : System.String

            //Returns type of string
            Console.WriteLine(firstname.GetTypeCode()); // : String

            //Returns the first index position of specified value the first index position of specified value
            Console.WriteLine(firstname.IndexOf("e")); // : 2

            //Covert string into lower case
            Console.WriteLine(firstname.ToLower()); // : steven clark

            //Convert string into Upper case
            Console.WriteLine(firstname.ToUpper()); // : STEVEN CLARK

            //Insert substring into string
            Console.WriteLine(firstname.Insert(0, "Hello")); // : HelloSteven Clark

            //Check Whether string is in Unicode normalization from C
            Console.WriteLine(firstname.IsNormalized()); // : True

            //Returns the last index position of specified value
            Console.WriteLine(firstname.LastIndexOf("e")); // : 4

            //Returns the Length of String
            Console.WriteLine(firstname.Length); // : 12

            //Deletes all the characters from begining to specified index.
            Console.WriteLine(firstname.Remove(5)); // : Steve

            // Replace the character
            Console.WriteLine(firstname.Replace('e', 'i')); // : Stivin Clark

            //Split the string based on specified value
            string[] split = firstname.Split(new char[] { 'e' }); 

            Console.WriteLine(split[0]); // : St
            Console.WriteLine(split[1]); // : v
            Console.WriteLine(split[2]); // : n Clark

            //Check wheter first character of string is same as specified value
            Console.WriteLine(firstname.StartsWith("S")); // : True

            //Returns substring
            Console.WriteLine(firstname.Substring(2, 5)); // : even

            //Converts an string into char array.
            Console.WriteLine(firstname.ToCharArray()); // : Steven Clark

            //It removes starting and ending white spaces from string.
            Console.WriteLine(firstname.Trim()); // : Steven Clark

        }
    }
}
