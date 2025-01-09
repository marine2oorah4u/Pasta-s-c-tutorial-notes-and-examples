using System.Drawing;


namespace PastasCSharpNotesAndExamples
{
    public static class TotalKnowledeLearned
    {
        public static void knowledge()
        {
            Helper.isTyping = false;

            bool keepRunning = true;


                Helper.writeLine("\t\t\n\n\n\tThe things that i have learned so far are:\n \n\n", Colors.defaultColor);
                Helper.write("\t\t-numberic based variables\n", Colors.limeGreen);

            ////////////////////////////////////////////////////////





            //System.Console.Clear();
            if (System.Console.KeyAvailable)
            {
                if (System.Console.KeyAvailable)
                    System.Console.ReadKey(true); // Consume the key press
                Helper.isTyping = false;
            }
            System.Threading.Thread.Sleep(1000);
             keepRunning = true;

            // Optionally wait for a key press before clearing to return to menu
            if (keepRunning)
            {
                Helper.writeLine("\n\n\n\n\n\nPress any key to return to the main menu...", Colors.defaultColor);
                System.Console.ReadKey(); // Wait for user input before clearing
                System.Console.Clear(); // Clear console to show the main menu again
            }
            else
                return;

               
        
    






         

        }
    }
}

