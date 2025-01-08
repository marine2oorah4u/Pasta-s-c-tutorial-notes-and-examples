using System;
using Colorful;
using SysConsole = System.Console;
using ColConsole = Colorful.Console;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ConsoleUI;
using static System.Net.Mime.MediaTypeNames;

namespace PastasCSharpNotesAndExamples
{
    public class ProgramMainProgram
    {

        public static async void mainMenu()
        {
            var defaultColor = Color.FromArgb(242, 159, 15);  //orange color

            bool keepRunning = true;
            Helper.isTyping = false;


            Helper.writeLine("\t\t\n\n\n\tWhat would you like to do?\n \n\n\n\n\n", Colors.blueJayBlue);



            while (keepRunning)
            {
                Helper.write("\t\tChoose an option:\n", Colors.limeGreen);
                Helper.write("\t\t1. ", Colors.numberColor);
                Helper.write("Total c# learned so far\n", Colors.lightYellow);
                Helper.write("\t\t2. ", Colors.numberColor);
                Helper.write("Notes & Code explanations\n", Colors.defaultColor);
                Helper.write("\t\t3. ", Colors.numberColor);
                Helper.write("Knowledge check & testing\n", Colors.salmonOrange);
                Helper.write("\t\t4. ", Colors.numberColor);
                Helper.write("small project/examples\n", Colors.blueJayBlue);
                Helper.write("\t\t5. ", Colors.numberColor);
                Helper.write("Return to the Main Menu\n", Colors.lightTeal);
                Helper.write("\t\t6. ", Colors.numberColor);
                Helper.write("Exit the Program\n", Colors.brightRed);

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
                            Helper.clearSettings();

                            TotalKnowledeLearned.knowledge();

                            //ProgramIntro.Run();
                            break;
                        case 2:
                            Helper.isTyping = false;

                            Helper.writeLine("You chose Option 2", Colors.defaultColor);   // for notes and examples
                            // Add your program execution logic here
                            Helper.clearSettings();
                            //ProgramMainProgram.mainMenu();

                            ProgramTest.Test();
                            break;
                        case 3:
                            Helper.isTyping = false;

                            Helper.clearSettings();


                            Helper.writeLine("Exiting program...", Colors.numberColor);    //for doing a Knowledge check & testing
                            //keepRunning = false;
                            break;
                        case 4:
                            Helper.isTyping = false;
                            Helper.clearSettings();

                            break;
                        case 5:
                            await Task.Delay(500); // Simulating some process

                            Helper.isTyping = false;
                            Helper.clearSettings();
                            Helper.isTyping = false;
                            SysConsole.Clear();
                            Program.Main(new string[] { });

                            break;
                        case 6:
                            Helper.isTyping = false;

                            Helper.writeLine("Exiting program...", Colors.defaultColor);
                            keepRunning = false;
                            System.Environment.Exit(0);                            //keepRunning = false; // Set keepRunning to false to exit the loop
                            break;
                        default:
                            Helper.writeLine("Invalid option. Please choose a valid option.", Colors.brightRed);
                            break;
                    }

                    // Optionally wait for a key press before clearing to return to menu
                    if (keepRunning)
                    {
                        Helper.writeLine("\nPress any key to return to the main menu...", Colors.defaultColor);
                        System.Console.ReadKey(); // Wait for user input before clearing
                        System.Console.Clear(); // Clear console to show the main menu again
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
