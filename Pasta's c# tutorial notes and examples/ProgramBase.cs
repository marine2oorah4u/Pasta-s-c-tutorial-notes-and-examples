using System.Drawing;
using ColConsole = Colorful.Console;
using SysConsole = System.Console;

namespace PastasCSharpNotesAndExamples
{
    internal class ProgramBase
    {
        void Main(string[] args)
        {
            // var Age = NumericDataTypesNotes.Age;
            // var bigNumber = NumericDataTypesNotes.bigNumber;

            // // Set ColConsole color to green for the first text
            // ColConsole.ForegroundColor = Color.FromArgb(0, 120, 0); // green
            // ColConsole.Write("Hello, World!");
            // ColConsole.ResetColor(); // Reset ColConsole color to default after this line

            // // Reset System.Console color to default (green)
            // SysConsole.ResetColor(); // Reset color for System.Console

            // // This will print in the default color (green)
            // SysConsole.WriteLine("Hello, World!");

            // SysConsole.WriteLine(Age);
            // SysConsole.WriteLine(bigNumber);

            // SysConsole.WriteLine("here are the ranges an int can have");

            // SysConsole.WriteLine($"the minimum value of an int is: {int.MinValue}");
            // SysConsole.WriteLine($"the maximum value of an int is: {int.MaxValue}");

            // SysConsole.WriteLine(int.MinValue); //shows the lowest value an int or var has
            // SysConsole.WriteLine(int.MaxValue); // shows the highest value an int or var has

            // SysConsole.WriteLine(uint.MinValue); //shows the lowest value an unsigned var has. 
            // SysConsole.WriteLine(uint.MaxValue); // shows the highest value an unsigned var has

            // SysConsole.WriteLine();
            // SysConsole.WriteLine(double.MinValue);
            // SysConsole.WriteLine(double.MaxValue);

            // SysConsole.WriteLine(float.MinValue);
            // SysConsole.WriteLine(float.MaxValue);

            // SysConsole.WriteLine(decimal.MinValue);
            // SysConsole.WriteLine(decimal.MaxValue);

            // SysConsole.ForegroundColor = ConsoleColor.Red;
            // SysConsole.WriteLine("This is a red line.");

            // // Change the text color to green for the second line
            // SysConsole.ForegroundColor = ConsoleColor.Green;
            // SysConsole.WriteLine("This is a green line.");

            // // Change the text color to blue for the third line
            // SysConsole.ForegroundColor = ConsoleColor.Blue;
            // SysConsole.WriteLine("This is a blue line.");

            // // Reset to the default console color
            // SysConsole.ResetColor();

            // // This line will be in the default color
            // SysConsole.WriteLine("This is the default color.");

            // // Define variables
            // string name = "Alice";
            // int age = 30;

            // // Set color for the static part of the string (the "Hello, my name is" part)
            // SysConsole.ForegroundColor = ConsoleColor.Yellow;
            // SysConsole.Write("Hello, my name is ");

            // // Set color for the interpolated variable (the name)
            // SysConsole.ForegroundColor = ConsoleColor.Magenta;
            // SysConsole.Write(name);

            // // Set color for the rest of the string (the "and I am 30 years old" part)
            // SysConsole.ForegroundColor = ConsoleColor.Cyan;
            // SysConsole.WriteLine($" and I am {age} years old.");

            // // Set a different color for another text
            // var orange = Color.FromArgb(255, 165, 0); // RGB for orange

            // // Use Colorful.Console to print text with RGB color
            //// ColConsole.WriteLine("This is some text in orange!", orange);

            // // Set a different color for another text
            // var green = Color.FromArgb(0, 255, 0); // RGB for green
            // ColConsole.WriteLine("This is some text in green!", green);

            // // Reset to default color for both ColConsole and SysConsole
            // ColConsole.ResetColor();
            // SysConsole.ResetColor();
            ColConsole.ForegroundColor = Color.FromArgb(220, 158, 61); // green
            System.Console.WriteLine("Hello, and welcome to my program!");
            ColConsole.ResetColor();
            SysConsole.ResetColor();

            System.Console.WriteLine("Hello, and welcome to ");


            //ProgramTest.Test();
        }
    }
}