using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecoverMaterial
{
    internal class Optimization
    {
        // Since we didnt learn it
        // We need to do it by our selves

        // Source : https://www.youtube.com/watch?v=3_JQGb3Zdq0
        // Summory

        /*
            Why we need this ? 
                Idk, just to save computer resourses and so it will run faster

            How to achive good preformance ? 
                Most of the time will be to avoid over calculation.

            Type of optimizations / efficiency
                1. By time (less calcuations / actions)
                2. By Memory (less using memory)
            Note ! by BAGRUT they will only focus on By Time optimization

            
            Example of counting amount of actions :

                Console.WriteLine("Enter 2 numbers ");   // 1 action
                int X = int.Parse(Console.ReadLine());   // 2 action
                int Y = int.Parse(Console.ReadLine());   // 3 action

                if (X > Y)  // 4 action 
                    Console.WriteLine(X);   // if true 5 action
                else {
                        // if false
                    int Temp = X;   // 5 action
                    X = Y;   // 6 action
                    Y = Temp;   // 7 action
                    Console.WriteLine(X);   // 8 action 
                }

            what is the amount of actions that the program will do ? 
            In good case : 5
            In bad case : 8
            In avarage : 7 (idk why poeple count this)

            when you will tell about the program (always)
            choose the bad case
    
            Second Example :

            char C = char.Parse(Console.ReadLine());    // 1 action

            // ! will represent the end of the input 
            while (C != 'd" && C != '!') {      // 3 actions inside [&& works also as action]
                C = char.Parse(Console.ReadLine()); // 1 more action
            }   // overall the loop will run [4n] times

            if (C == 'd') // next action
                return true; // 1 action
            else
                return false; // 2 action

            In bad & good case : 4n + 3 actions
            
            
            מושגים :
            פונקציית זמן ריצה - מספר הפעולות שמבצע האלגוריתם במקרה הגרוע ביותר

            סיבוכיות זמן ריצה \ יעילות \ סדר גודל - הגורם הכי קריטי (משפיע) בפונקציית זמן ריצה
            מסמנים את היעילות באות
            O

            פעולה בסיסית - פעולה שלא תלוייה באורך הקלט, אבל יכולה להיות מושפעת ממנו

            Examples :
                In the first code i provided
                פונקצית זמן ריצה : 7
                סיבוכיות זמן ריצה : O(1) [we know from the start the length of the program]

                The second code 
                4n + 3 : פונקצית זמן ריצה
                סיבוכיות זמן ריצה : O(n) [n - amount of loops]

            
            overall this is everything that was mentioned in the video 

            Warnings ! 
                1. never write like 0(2n) -> correct : O(n)
                2. never set by default the ;Orders of magnitude; by vision
                3. never think that if the code is short, it is more efficient
         */

    }
}
