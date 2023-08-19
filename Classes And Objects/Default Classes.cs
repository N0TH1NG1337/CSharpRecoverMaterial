using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial.Classes_And_Objects
{
    internal class Default_Classes
    {
        /*
            Classes [Objects]
            (our own type of data)

            Create one :
                
                [optinal : type of class] class Name {
                    
                    // First of all we declare the data that the class will have
                    // Note ! all the properties must be private
                    private [type] NameOfData; // 1. you dont set any values here | 2. must add short description about this

                    // Then you must create a constractor / builder function
                    public Name( ... ) {
                        // In most cases you will have to get the data to the function and set values
                        // Warning ! must use [this.]
                        this.NameOfData = ... ;
                    }

                    // Then we need to create functions to access data
                    // We create getters and setters
                    
                    // Getters
                    // Optinal ! the name of the functions will be [Get/Set] + [Name of the data]
                    public [type] GetData() { return this.NameOfData; } 

                    // Setters
                    public void SetData(...) { this.NameOfData = ...; }


                    // Here you add other functions that are connected to the object
                    ...

                    // And in the end you create ToString function (more correctly you override the current one)
                    public override string ToString() {
                        return "...";
                    }
                }


            This is how you create the class, now you will see how to use it
            To use the class you create you use it like type of data
            for example like you create new number var :

            [int Number = 10;]

            you create object like this (Can also create empty placeholder)
                
            [NameOfClass NameOfVar = new NameOfClass(... data that you setted in constractor); ]
            [NameOfClass NameOfVar;]
            
        */
    }
}
