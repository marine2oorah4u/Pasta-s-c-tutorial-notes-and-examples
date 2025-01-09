using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;


namespace PastasCSharpNotesAndExamples
{
    public class NumericVariableNotesAndExamples
    {

        public static void Options()
        {
            bool keepRunning = true;
            Helper.isTyping = false;
            System.Threading.Thread.Sleep(500);

            Helper.writeLine("\t\t\n\n\n\tWhich C# topic would you like to dive into today?\n \n\n\n\n\n", Colors.blueJayBlue);



            while (keepRunning)
            {
                Helper.write("\t\tChoose an option:\n", Colors.limeGreen);
                Helper.write("\t\t1. ", Colors.numberColor);
                Helper.write("Numeric based Variables + knowledge\n", Colors.lightYellow);
                Helper.write("\n\n\n\t\t2. ", Colors.numberColor);
                Helper.write("Return to the main menu\n", Colors.lavender);


                //Helper.write("\t\t2. ", Colors.numberColor);
                //Helper.write("Notes & Code explanations\n", Colors.defaultColor);
                //Helper.write("\t\t3. ", Colors.numberColor);
                //Helper.write("Knowledge check & testing\n", Colors.salmonOrange);
                //Helper.write("\t\t4. ", Colors.numberColor);
                //Helper.write("small project/examples\n", Colors.blueJayBlue);
                //Helper.write("\t\t5. ", Colors.numberColor);
                //Helper.write("Return to the Main Menu\n", Colors.lightTeal);
                //Helper.write("\t\t6. ", Colors.numberColor);
                //Helper.write("Exit the Program\n", Colors.brightRed);

                try
                {
                    // Reset Console.KeyAvailable flag
                    while (Colorful.Console.KeyAvailable)
                    {
                        Colorful.Console.ReadKey(true); // Consume the key press
                    }

                    Colorful.Console.ForegroundColor = Colors.numberColor;
                    int option = Convert.ToInt32(System.Console.ReadLine());

                    // Clear the console to remove the options before executing the selected option
                    System.Console.Clear();

                    switch (option)
                    {
                        case 1:
                            Helper.isTyping = false;

                            Helper.writeLine("You chose Option 1", Colors.defaultColor);   //for knowledge learned so far
                            System.Console.Clear();
                            Colorful.Console.Clear();

                            Colorful.Console.ResetColor();
                            System.Console.ResetColor();
                            System.Threading.Thread.Sleep(1000);

                            TotalKnowledeLearned.knowledge();

                            //ProgramIntro.Run();
                            break;
                        case 2:


                            Helper.isTyping = false;

                            Task.Delay(500); // Simulating some process

                            Helper.clearSettings();
                            ProgramMainProgram.mainMenu();

                            break;

                        default:
                            Helper.writeLine("Invalid option. Please choose a valid option.", Colors.brightRed);
                            break;
                    }
                }


                catch (FormatException)
                {
                    //System.Console.Clear();
                    Helper.writeLine("Invalid input. Please enter a number.", Colors.brightRed);
                }
                catch (OverflowException)
                {
                    //System.Console.Clear();
                    Helper.writeLine("Input is too large. Please enter a smaller number.", Colors.brightRed);
                }
                catch (Exception ex)
                {
                    //System.Console.Clear();
                    Helper.writeLine("An error occurred: " + ex.Message, Colors.brightRed);
                }
            }
        }
    }
}
