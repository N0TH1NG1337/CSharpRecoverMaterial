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

        /*
            Append(string): Adds a string to the current string.

            AppendLine(string): Adds a string to the current string, with a new line at the end.

            Clear(): Clears the string.

            Contains(string / char): Determines whether the current string contains the specified string.

            CopyTo(char[], int, int): Copies the current string to a char array.

            EndsWith(string): Determines whether the current string ends with the specified string.

            Equals(object): Determines whether the current string is equal to the specified object.

            Equals(string, StringComparison): Determines whether the current string is equal to the specified string, according to the specified comparison method.

            Format(string, object[]): Formats a string with the specified parameters.

            IndexOf(char): Gets the index of the first occurrence of the specified character in the current string.

            IndexOf(char, int): Gets the index of the first occurrence of the specified character in the current string, starting at the specified index.

            IndexOf(string): Gets the index of the first occurrence of the specified string in the current string.

            IndexOf(string, int): Gets the index of the first occurrence of the specified string in the current string, starting at the specified index.

            Insert(int, string): Inserts the specified string into the current string, at the specified index.

            Length : Gets the length of the string.

            Remove(int, int): Removes a substring from the current string, starting at the specified index.

            Replace(char, char): Replaces all occurrences of the specified character in the current string with the specified character.

            Replace(string, string): Replaces all occurrences of the specified string in the current string with the specified string.

            Split(string): Splits the current string into an array of strings, using the specified string as the delimiter.

            Substring(int): Gets a substring from the current string, starting at the specified index.

            Substring(int, int): Gets a substring from the current string, starting at the specified index and ending at the specified index.

            ToLower(): Converts all characters in the current string to lowercase.

            ToUpper(): Converts all characters in the current string to uppercase.

            Trim(): Removes all leading and trailing whitespace from the current string.

            TrimEnd(char[]): Removes all specified characters from the end of the current string.

            TrimStart(char[]): Removes all specified characters from the beginning of the current string.
        */

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
            // ! Console.WriteLine(firstname.GetHashCode()); // : 1470518261

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
            // ! Console.WriteLine(firstname.IsNormalized()); // : True

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
