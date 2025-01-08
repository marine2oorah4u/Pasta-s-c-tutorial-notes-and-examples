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
    class Program
    {
        public static bool keepRunning;

        public static async Task Main(string[] args)
        {
            {
                Helper.isTyping = false;

                //                     Colorful.Console.BackgroundColor = Color.FromArgb (200,0,200);  background does a highlight of text


                Helper.writeLine("\t\t\n\n\n\tWelcome to my program!\n \tWhat do you want to do?\n\n\n\n\n", Colors.defaultColor);
                                Helper.isTyping = false;

                keepRunning = true;
                while (keepRunning)
                {

                    //System.Console.Write("This is ");
                    ////System.Console.Write("highlighted", Color.White, Color.Green);
                    //System.Console.WriteLine(" text.");
                   Helper.writeLine("\t\tChoose an option:\n", Colors.limeGreen);


                    ////////////////////////////////////////////////////////

                    Helper.write("\t\t1. ", Colors.numberColor);

                    Colorful.Console.ForegroundColor = Colors.lightYellow;
                    Helper.write("About my program.\n", Colors.lightYellow);  //option 1
                                                                              ////////////////////////////////////////////////////////


                    Helper.write("\t\t2. ", Colors.numberColor);

                    Helper.write("Run the program.\n", Colors.salmonOrange);  //option 2
                                                                   ////////////////////////////////////////////////////////

                    Helper.write("\t\t3. ", Colors.numberColor);

              
                    Helper.write("Exit the program.\n", Colors.lightPurple);  //option 3
                                                                    ////////////////////////////////////////////////////////

                    Colorful.Console.ForegroundColor = Colors.blueJayBlue;
                    Helper.write("\n\n\tEnter your choice: ", Colors.blueJayBlue);
                    //Colorful.Console.ForegroundColor = Color.FromArgb(255, 255, 255);


                    try
                    {
                        Colorful.Console.ForegroundColor = Colors.numberColor;
                        int option = Convert.ToInt32(System.Console.ReadLine());


                        // Clear the console to remove the options before executing the selected option
                        System.Console.Clear();

                        switch (option)
                        {
                            case 1:
                                Colorful.Console.ForegroundColor = Colors.defaultColor;
                                Helper.writeLine("You chose Option 1", Colors.defaultColor);
                                Colorful.Console.ResetColor();
                                System.Console.ResetColor();
                                await Task.Delay(500); // Simulating some process

                                ProgramIntro.Run();        // runs the about me and this program information
                                break;
                            case 2:
                                Helper.writeLine("You chose Option 2", Colors.defaultColor);
                                // Add your program execution logic here
                                Colorful.Console.ResetColor();
                                System.Console.ResetColor();
                                await Task.Delay(500); // Simulating some process
                                System.Console.Clear();
                                await ProgramMainProgram.mainMenu();

                                //ProgramTest.Test();
                                break;
                            case 3:
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
}
    