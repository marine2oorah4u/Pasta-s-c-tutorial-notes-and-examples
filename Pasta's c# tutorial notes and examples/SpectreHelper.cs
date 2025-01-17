using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastasCSharpNotesAndExamples
{
    class SpectreHelper
    {
        /// <summary>
        /// this is how to add a bullet point list using Spectre.Console
        /// </summary>
        /// 
        public static void bulletPointExample()
        {
            AnsiConsole.Markup("[green]*  Item 1 [/]\n[red]* Item 2[/]\n[red]* Item 2[/]\n[red]* Item 2[/]\n[red]* Item 2[/]\n\n");
            //the first [] is to give the color
        }






        /// <summary>
        /// this is an example of how to make a tree like diagram
        /// </summary>
        public static void treeExample()
        {
            var tree = new Tree("[green] Root[/]");

            // Level 1
            var branch1 = tree.AddNode("[red] Branch 1[/]");  //this is what will stem as the main branch, as main lines?
                                                              // these can also have other branches on it as well if wanted
                                                              // can basically be done indefinately if needed
            var branch2 = tree.AddNode("[red] Branch 2[/]");

            // Level 2
            var subBranch1 = branch1.AddNode("[yellow] Sub-Branch 1.1[/]");     //  these will branch off or break from the branches even further, similar to leaves on a tree
                                                                                // that is done via referencing the branch, say (branch1) in this instance, 
                                                                                // and then creating that leaf or sub branch on the main branch
            var subBranch2 = branch1.AddNode("[yellow] Sub-Branch 1.2[/]");
            var subBranch3 = branch2.AddNode("[yellow] Sub-Branch 2.1[/]");

            // Level 3
            var subSubBranch1 = subBranch1.AddNode("[green] Sub-Sub-Branch 1.1.1[/]");
            var subSubBranch2 = subBranch1.AddNode("[green] Sub-Sub-Branch 1.1.2[/]");
            var subSubBranch3 = subBranch2.AddNode("[green] Sub-Sub-Branch 1.2.1[/]");

            // Level 4
            var subSubSubBranch1 = subSubBranch1.AddNode("[blue] Sub-Sub-Sub-Branch 1.1.1.1[/]");
            var subSubSubBranch2 = subSubBranch1.AddNode("[blue] Sub-Sub-Sub-Branch 1.1.1.2[/]");

            // Level 5
            var subSubSubSubBranch1 = subSubSubBranch1.AddNode("[red] Sub-Sub-Sub-Sub-Branch 1.1.1.1.1[/]");




            // Render the tree
            AnsiConsole.Render(tree);   // this is done to call or make the tree appear in console
        }






        /// <summary>
        /// this is to show a loading bar in the console
        /// </summary>
        public static void loadingBar()
        {
            AnsiConsole.Progress()
   .Columns(new ProgressColumn[]
   {
                new TaskDescriptionColumn(), // Task description
                new ProgressBarColumn(), // Progress bar
                new PercentageColumn(), // Percentage
                new SpinnerColumn(), // Spinner
   })
   .Start(ctx =>
   {
       var task = ctx.AddTask("Loading");
       while (!task.IsFinished)
       {
           task.Increment(10);    // this will show how much it increases by per incriment
           Thread.Sleep(100);     // this is how quick it updates the loading bar
       }
   });
        }


        /// <summary>
        /// this will help to show how to take an image from a folder, usually say...
        /// (C:\Users\User\source\repos\Pasta's c# tutorial notes and examples\Pasta's c# tutorial notes and examples\bin\Release\net8.0)
        /// and then whatever you use for the image name, it will use that image. note it wont be the clearest
        /// picture, being the 
        /// </summary>
        public static void imageLoader()
        {
            var canvasImage = new CanvasImage("image.png");    // deterine what image you wish to use
            canvasImage.PixelWidth(15);   // how wide or big the image will be. this wont affect the actual pixels, via making it clearer
            AnsiConsole.Write(canvasImage);      // to write the image
        }






        /// <summary>
        /// this is to help
        /// </summary>
        public static void tableHelp()
        {
            var table2 = new Table();


            table2.AddColumn("Name");
            table2.AddColumn("Description");
            table2.AddColumn("Maybe");
            table2.AddRow("Age", "Yes", "No");
            AnsiConsole.Render(table2);
        }


        /// <summary>
        /// this is examples of how to use the callendar with AnsiConsole
        /// </summary>
        public static void calendarHelp()
        {
            // this is a basic level calendar

            var calendar = new Calendar(2020, 10);
            AnsiConsole.Write(calendar);

            ////////////////////////////////////////


            //this is to highlight certain days if needed
            var calendar1 = new Calendar(2020, 10);
            calendar.AddCalendarEvent(2020, 10, 11);
            calendar.HighlightStyle(Style.Parse("yellow bold"));
            AnsiConsole.Write(calendar1);

            ////////////////////////////////////////

            //this is to make the header a different color or highlight it if needed

            var calendar2 = new Calendar(2020, 10);
            calendar.HeaderStyle(Style.Parse("blue bold"));
            AnsiConsole.Write(calendar);

        }


        public static void tableHelp2()
        {
            var table2 = new Table();

            // Add columns for each step
            table2.AddColumn(new TableColumn("Column 1").Centered());
            table2.AddColumn(new TableColumn("Column 2").Centered());
            table2.AddColumn(new TableColumn("Column 3").Centered());
            table2.AddColumn(new TableColumn("Column 4").Centered());

            // Step 1: Add First Row of Panels (Red)
            var panel1 = new Panel(new Markup("[red]ABC[/]")).BorderColor(Color.Red);
            var panel2 = new Panel(new Markup("[red]DEF[/]")).BorderColor(Color.Red);
            var panel3 = new Panel(new Markup("[red]GHI[/]")).BorderColor(Color.Red);
            var panel4 = new Panel(new Markup("[red]Hej[/]")).BorderColor(Color.Red);

            table2.AddRow(panel1, panel2, panel3, panel4);

            // Step 2: Add Second Row with Markup (Yellow) in Panels
            var panel5 = new Panel(new Markup("[yellow]Hello[/]")).BorderColor(Color.Yellow);
            var panel6 = new Panel(new Markup("[yellow]World![/]")).BorderColor(Color.Yellow);
            var panel7 = new Panel(new Markup("[yellow]Hej[/]")).BorderColor(Color.Yellow);
            var panel8 = new Panel(new Markup("[yellow]Hej[/]")).BorderColor(Color.Yellow);

            table2.AddRow(panel5, panel6, panel7, panel8);

            // Step 3: Add Third Row of Panels (Green)
            var panel9 = new Panel(new Markup("[green]Foo[/]\n[green]Hello[/]\n[green]Bonjour[/]")).BorderColor(Color.Green);
            var panel10 = new Panel(new Markup("[green]Bar[/]\n[green]World![/]")).BorderColor(Color.Green);
            var panel11 = new Panel(new Markup("[green]Baz[/]\n[green]Whaaat[/]")).BorderColor(Color.Green);
            var panel12 = new Panel(new Markup("[green]Hej[/]")).BorderColor(Color.Green);

            table2.AddRow(panel9, panel10, panel11, panel12);

            // Step 4: Add Fourth Row with Inner Table (Blue)
            var panel13 = new Panel(new Markup("[blue]CDE[/]\n[blue]Hello[/]\n[blue]Hej[/]")).BorderColor(Color.Blue);
            var panel14 = new Panel(new Markup("[blue]FED[/]\n[blue]World![/]")).BorderColor(Color.Blue);

            var innerTable = new Table();
            innerTable.AddColumn(new TableColumn("[blue]Inner 1[/]").Centered());
            innerTable.AddColumn(new TableColumn("[blue]Inner 2[/]").Centered());
            innerTable.AddRow("[blue]Inner Cell 1[/]", "[blue]Inner Cell 2[/]");
            innerTable.AddRow("[blue]Inner Cell 3[/]", "[blue]Inner Cell 4[/]");

            var panelWithTable = new Panel(innerTable).BorderColor(Color.Blue);
            var panel15 = new Panel(new Markup("[blue]Hej[/]")).BorderColor(Color.Blue);

            table2.AddRow(panel13, panel14, panelWithTable, panel15);

            // Step 5: Add Footer Rows (Magenta)
            var panel16 = new Panel(new Markup("[magenta]Hej[/]")).BorderColor(Color.Purple);
            var panel17 = new Panel(new Markup("[magenta]Världen![/]")).BorderColor(Color.Purple);
            var panel18 = new Panel(new Markup("[magenta]Footer 1[/]")).BorderColor(Color.Purple);
            var panel19 = new Panel(new Markup("[magenta]Footer 2[/]")).BorderColor(Color.Purple);

            table2.AddRow(panel16, panel17, panel18, panel19);

            var panel20 = new Panel(new Markup("[magenta]Footer 1[/]")).BorderColor(Color.Purple);
            var panel21 = new Panel(new Markup("[magenta]Footer 2[/]")).BorderColor(Color.Purple);
            var panel22 = new Panel(new Markup("[magenta]Footer 3[/]")).BorderColor(Color.Purple);
            var panel23 = new Panel(new Markup("[magenta]Footer 4[/]")).BorderColor(Color.Purple);

            table2.AddRow(panel20, panel21, panel22, panel23);

            // Render the table to the console
            AnsiConsole.Write(table2);
        }




    }
}
