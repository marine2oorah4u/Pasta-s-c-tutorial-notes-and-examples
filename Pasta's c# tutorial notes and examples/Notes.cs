using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PastasCSharpNotesAndExamples
{
    /// <summary>
    /// use this section to display any fun facts and easter eggs or useages
    /// </summary>
     internal class Notes
    {
              
        //f5 = shortcut to start program


    }

    /// <summary>
    /// use this to show different functions or code and how they're done + their  uses(?)
    /// </summary>
    internal class FunctionNotes
    {
        /*Console.WriteLine = displays what is shown in {"text here"}
         * Console.ReadLine = reads the users input
         * 
         * initializing 
         * 
         * 
         * 
         */

    }

    /// <summary>
    /// use this section to show code examples
    /// </summary>

}

public  class NumericDataTypesNotes
{
    public static int Age = 23;  // Shared variable
    public static string Name = "John Doe";  // Shared variable
   public static long bigNumber = 90000000L; //for better readability or specifying,
                                            // use a L at the end of a int value, if its an Long or value above an int range
                                            //and also use a capital L, instead of lowercase l, being l can get mistaken for 1 at times
   
    public static double negative = -55.2D;  // for doubles, you can use a D at the end for its syntax,allthough not required

    public static float precision = 5.000001f;   // for floats, an f is required at the end of a numeric value
                                                 // this is to help diferentiate between a float, double, and decimal
                                                 // if you tried to make that float without f, it would assume its a double, and error out

    //public static void PrintGreeting()
    //{
    //    Console.WriteLine($"Hello, my name is {Name}, and I am {Age} years old.");
    //}
    // 23 = declaring

    //could alternatively be done via

    // int age;
    // age = 23 

    //Console.WriteLine (age);

}
