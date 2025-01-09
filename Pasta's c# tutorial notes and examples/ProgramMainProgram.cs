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
using PastasCSharpNotesAndExamples;

namespace PastasCSharpNotesAndExamples
{


    public static class ProgramStart
    {
        public static void start()
        {
            Helper.isTyping = false;

            //                     Colorful.Console.BackgroundColor = Color.FromArgb (200,0,200);  background does a highlight of text


            Helper.writeLine("\t\t\n\n\n\tWelcome to my program!\n \tWhat do you want to do?\n\n\n\n\n", Colors.defaultColor);

            bool keepRunning = true;
            while (keepRunning)
            {

             
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
                            Colorful.Console.Clear();
                            Colorful.Console.ResetColor();
                            System.Console.ResetColor();
                            System.Threading.Thread.Sleep(1000);

                            ProgramIntro.Run();        // runs the about me and this program information
                            break;
                        case 2:
                            Helper.writeLine("You chose Option 2", Colors.defaultColor);
                            // Add your program execution logic here
                            Colorful.Console.ResetColor();
                            System.Console.ResetColor();
                            System.Threading.Thread.Sleep(1000);
                            System.Console.Clear();
                             ProgramMainProgram.mainMenu();

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
                        System.Threading.Thread.Sleep(500);
                        ProgramStart.start();

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

public static class ProgramMainProgram
{
    public static void mainMenu()
    {
        var defaultColor = Color.FromArgb(242, 159, 15);  //orange color
        bool keepRunning = true;
        Helper.isTyping = false;
        System.Threading.Thread.Sleep(500);

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

                            Helper.writeLine("You chose Option 2", Colors.defaultColor);   // for notes and examples
                        Colorful.Console.Clear();
                        Colorful.Console.ResetColor();
                        System.Console.ResetColor();
                        System.Threading.Thread.Sleep(1000);

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
                            Helper.isTyping = false;

                            Task.Delay(500); // Simulating some process

                            Helper.clearSettings();


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

