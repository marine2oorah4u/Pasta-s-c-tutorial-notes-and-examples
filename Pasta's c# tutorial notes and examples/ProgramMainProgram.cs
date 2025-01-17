using System;
using SysConsole = System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawingColor = System.Drawing.Color;
using ConsoleUI;
using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;
using PastasCSharpNotesAndExamples;
using Colorful;

namespace PastasCSharpNotesAndExamples
{
    public static class ProgramStart
    {
        public static void start()
        {
            Helper.isTyping = false;

            var loadingGrid = new Grid();
            loadingGrid.AddColumn(new GridColumn().Width(30));
            loadingGrid.AddColumn(new GridColumn());

            loadingGrid.AddRow(
                new Markup("\t\t\n\n"),
                new Markup("[bold yellow]\t\tLoading...[/]")
            );

            AnsiConsole.Render(loadingGrid);

            AnsiConsole.Progress()
                .Columns(new ProgressColumn[]
                {
                    new TaskDescriptionColumn(),
                    new ProgressBarColumn(),
                    new PercentageColumn(),
                    new SpinnerColumn(),
                })
                .Start(ctx =>
                {
                    var task = ctx.AddTask("\t\t   Loading");
                    while (!task.IsFinished)
                    {
                        task.Increment(10);
                        Thread.Sleep(100);
                    }
                });

            Thread.Sleep(100);

            var canvasImage = new CanvasImage("image.png");
            canvasImage.MaxWidth(15);

            var grid = new Grid();
            grid.AddColumn(new GridColumn().Width(40));
            grid.AddColumn(new GridColumn().Width(50));
            grid.AddRow(Spectre.Console.Text.Empty, canvasImage);

            AnsiConsole.Render(grid);

            var titleRule = new Rule("[bold yellow]Welcome to the Console App[/]").Centered();
            AnsiConsole.Write(titleRule);

            var figletText = new FigletText("HELLO")
                .Centered()
                .Color(Spectre.Console.Color.Blue);
            AnsiConsole.Render(figletText);

            var separatorRule = new Rule("[bold red]====================[/]").Centered();
            AnsiConsole.Write(separatorRule);

            Helper.writeLine("\t\t\n\n\n\tWelcome to my program!\n \tWhat do you want to do?\n\n\n\n\n", Colors.defaultColor);

            bool keepRunning = true;
            while (keepRunning)
            {
                Helper.writeLine("\t\tChoose an option:\n", Colors.limeGreen);

                Helper.write("\t\t1. ", Colors.numberColor);
                Helper.write("About my program.\n", Colors.lightYellow);

                Helper.write("\t\t2. ", Colors.numberColor);
                Helper.write("Run the program.\n", Colors.salmonOrange);

                Helper.write("\t\t3. ", Colors.numberColor);
                Helper.write("Exit the program.\n", Colors.lightPurple);

                Helper.write("\n\n\tEnter your choice: ", Colors.blueJayBlue);

                try
                {
                    int option = Convert.ToInt32(SysConsole.ReadLine());
                    SysConsole.Clear();

                    switch (option)
                    {
                        case 1:
                            Helper.writeLine("You chose Option 1", Colors.defaultColor);
                            SysConsole.Clear();
                            Colorful.Console.Clear();
                            SysConsole.ResetColor();
                            Thread.Sleep(1000);
                            ProgramIntro.Run();
                            break;
                        case 2:
                            Helper.writeLine("You chose Option 2", Colors.defaultColor);
                            SysConsole.Clear();
                            ProgramMainProgram.mainMenu();
                            break;
                        case 3:
                            Helper.writeLine("Exiting program...", Colors.defaultColor);
                            keepRunning = false;
                            Environment.Exit(0);
                            break;
                        default:
                            Helper.writeLine("Invalid option. Please choose a valid option.", Colors.brightRed);
                            break;
                    }

                    if (keepRunning)
                    {
                        Helper.writeLine("\nPress any key to return to the main menu...", Colors.defaultColor);
                        SysConsole.ReadKey();
                        SysConsole.Clear();
                        Thread.Sleep(500);
                        ProgramStart.start();
                    }
                }
                catch (FormatException)
                {
                    Helper.writeLine("Invalid input. Please enter a number.", Colors.brightRed);
                }
                catch (OverflowException)
                {
                    Helper.writeLine("Input is too large. Please enter a smaller number.", Colors.brightRed);
                }
                catch (Exception ex)
                {
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


        var defaultColor = Colors.salmonOrange;
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

                        NotesAndExamples.Options();
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


                            //Program.Main(new string[] { });


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


public static class NotesAndExamples
{
    public static void Options()
    {
        var defaultColor = Colors.salmonOrange;
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

                        NumericVariableNotesAndExamples.Options();

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


