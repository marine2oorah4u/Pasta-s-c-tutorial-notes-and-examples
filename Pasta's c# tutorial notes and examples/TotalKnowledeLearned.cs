using System.Drawing;


namespace PastasCSharpNotesAndExamples
{
    public class TotalKnowledeLearned
    {
        public async static void knowledge()
        {
            Helper.isTyping = false;

            bool keepRunning = true;

  

            Helper.writeLine("\t\t\n\n\n\tThe things that i have learned so far are:\n \n\n\n\n\n", Colors.defaultColor);
            Helper.write("\t\t-numberic based variables\n", Colors.limeGreen);


            Colorful.Console.ForegroundColor = Colors.numberColor;
            Colorful.Console.Write("\t\t1. ");

            Colorful.Console.ForegroundColor = Colors.lightYellow;
            Colorful.Console.Write("Total c# learned so far\n");

            Colorful.Console.ForegroundColor = Colors.numberColor;
            Colorful.Console.Write("\t\t2. ");

            Colorful.Console.ForegroundColor = Colors.defaultColor;
            Colorful.Console.Write("Notes & Code explanations\n");

            Colorful.Console.ForegroundColor = Colors.numberColor;
            Colorful.Console.Write("\t\t3. ");

            Colorful.Console.ForegroundColor = Colors.salmonOrange;
            Colorful.Console.Write("Notes & Code Examples\n");

            Colorful.Console.ForegroundColor = Colors.numberColor;
            Colorful.Console.Write("\t\t4. ");

            Colorful.Console.ForegroundColor = Colors.blueJayBlue;
            Colorful.Console.Write("small project/examples \n");



            // Optionally wait for a key press before clearing to return to menu
            if (keepRunning)
            {
                //System.Console.WriteLine("\nPress any key to return to the main menu...");
                System.Console.ReadKey(); // Wait for user input before clearing
                System.Console.Clear(); // Clear console to show the main menu again
            }
        }
        //catch (FormatException)
        //{
        //    //System.Console.Clear();
        //    Helper.writeLine("Invalid input. Please enter a number.", Colors.brightRed);
        //}
        //catch (OverflowException)
        //{
        //    //System.Console.Clear();
        //    Helper.writeLine("Input is too large. Please enter a smaller number.", Colors.brightRed);
        //}

    }
}

