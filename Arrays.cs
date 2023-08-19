using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial
{
    internal class Arrays
    {
        /*
            Array [single dimension]
            (list of 1 type)

            Note ! Array are limited in size 
            (you create an array and you cannot change the size)

            Create one :

                [option 1]
                type[] Name = new type[number of cells];

                [option 2]
                type[] Name = {...}; // you insert the start value manually

            Warning ! When you create an array, it works like address,
                if you pass it to other var it will work on the same array.
                To avoid it, create new one,
                in addition, you dont need to return an array

            Access Data from Array : 
            Name[Index] : 0 -> (Length - 1)

            Just to say also array works like object with functions
            Array's methods (common) : 
                
                Append(array, value): Appends the specified value to the end of the array.
                Clear(array): Clears the array.
                Copy(array, sourceArray, startIndex, endIndex): Copies the specified range of elements from the source array to the destination array.
                Fill(array, value): Fills the array with the specified value.
                Length : Returns the length of the array
                IndexOf(array, value): Gets the index of the first occurrence of the specified value in the array.
                Insert(array, index, value): Inserts the specified value into the array at the specified index.
                Reverse(array): Reverses the order of the elements in the array.
                Sort(array): Sorts the elements in the array.
                
                ToList(array): Converts the array to a List<T>.
                ToString(array): Converts the array to a string.
         */

        /*
            Array [multi dimensions]
            (almost the same but a little different in create / work)
            
         */

        void Examples() {
            int[] Array = { 1, 2, 3 };

            Console.WriteLine(Array.Length);
        }

        
    }
}
