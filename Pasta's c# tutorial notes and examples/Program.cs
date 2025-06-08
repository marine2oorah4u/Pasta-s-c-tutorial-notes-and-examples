using Spectre.Console;
using System;


namespace PastasCSharpNotesAndExamples
{
    class Program
    {
        public static void Main(string[] args)
        {














            ////  to display a loading bar

            //var loadingGrid = new Grid();
            //loadingGrid.AddColumn(new GridColumn().Width(30)); // Adjust width for padding
            //loadingGrid.AddColumn(new GridColumn()); // Column for the progress bar

            //loadingGrid.AddRow(
            //    new Markup("\t\t\n\n"), // Empty for padding
            //    new Markup("[bold yellow]\t\tLoading...[/]") // Loading text
            //);

            //AnsiConsole.Render(loadingGrid);


            //AnsiConsole.Progress()
            //    .Columns(new ProgressColumn[]
            //    {
            //        new TaskDescriptionColumn(),
            //        new ProgressBarColumn(),
            //        new PercentageColumn(),
            //        new SpinnerColumn(),
            //    })
            //    .Start(ctx =>
            //    {
            //        var task = ctx.AddTask("\t\t   Loading"); // Add spaces for padding
            //        while (!task.IsFinished)
            //        {
            //            task.Increment(10);
            //            Thread.Sleep(100);
            //        }
            //    });


            //Thread.Sleep(100);

            ////  to display a loading bar



            //var canvasImage = new CanvasImage("image.png");
            //canvasImage.MaxWidth(15);

            //// Use a grid to position the image and text
            //var grid = new Grid();

            //// Add columns and rows for layout
            //grid.AddColumn(new GridColumn().Width(40)); // Adjust the width for padding
            //grid.AddColumn(new GridColumn().Width(50)); // Column for the image and text

            //// Add the image in the first row
            //grid.AddRow(Text.Empty, canvasImage);

            //// Render the grid (image and text) to the console
            //AnsiConsole.Render(grid);

            //// Create and display the title rule
            //var titleRule = new Rule("[bold yellow]Welcome to the Console App[/]").Centered();
            //AnsiConsole.Write(titleRule);

            //// Create and display Figlet text
            //var figletText = new FigletText("HELLO")
            //    .Centered()
            //    .Color(Color.Blue);
            //AnsiConsole.Render(figletText);

            //// Display a separator rule
            //var separatorRule = new Rule("[bold red]====================[/]").Centered();
            //AnsiConsole.Write(separatorRule);



            //AnsiConsole.Write(new Rule("[blue]Welcome to the Console App[/]").RuleStyle("grey").Centered());

            //// Display a welcome message
            //AnsiConsole.MarkupLine("[bold yellow]Welcome to my program![/]");

            //// Prompt the user
            //AnsiConsole.MarkupLine("\n\n[italic]What would you like to do?[/]\n");

            //// Display the menu
            //var options = new[] { "Option 1", "Option 2", "Option 3", "Option 4" };
            //var selectedOption = AnsiConsole.Prompt(
            //    new SelectionPrompt<string>()
            //        .Title("[green]Select an option by pressing the corresponding number:[/]")
            //        .PageSize(4)
            //        .AddChoices(options));

            //// Process the input using a switch statement
            //switch (selectedOption)
            //{
            //    case "Option 1":
            //        AnsiConsole.MarkupLine("You selected [bold]Option 1[/].");
            //        break;
            //    case "Option 2":
            //        AnsiConsole.MarkupLine("You selected [bold]Option 2[/].");
            //        break;
            //    case "Option 3":
            //        AnsiConsole.MarkupLine("You selected [bold]Option 3[/].");
            //        break;
            //    case "Option 4":
            //        AnsiConsole.MarkupLine("You selected [bold]Option 4[/].");
            //        break;
            //    default:
            //        AnsiConsole.MarkupLine("[red]Invalid selection. Please try again.[/]");
            //        break;
            //}

            //// Display the footer
            //AnsiConsole.Write(new Rule("[blue]====================[/]").RuleStyle("grey").Centered());
            //// Constant


            //// Create and render a table
            //var table2 = new Table();


            //table2.AddColumn("Name");
            //table2.AddColumn("Description");
            //table2.AddColumn("Maybe");
            //table2.AddRow("Age", "Yes", "No");
            //AnsiConsole.Render(table2);

            //AnsiConsole.Markup("[bold blue]Image rendering might require a different approach.[/]");
            //AnsiConsole.Markup("[green]* Item 1[/]\n[red]* Item 2[/]");

            //// Progress Bar
            //AnsiConsole.Progress()
            //    .Start(ctx =>
            //    {
            //        var task = ctx.AddTask("Loading");
            //        while (!task.IsFinished)
            //        {
            //            task.Increment(10);
            //            Thread.Sleep(100);
            //        }
            //    });

            //// Create another Grid for other elements
            //var contentGrid = new Grid();
            //contentGrid.AddColumn();
            //contentGrid.AddColumn();
            //contentGrid.AddRow("Left", "Right");
            //AnsiConsole.Render(contentGrid);

            //// Panel
            //var panel = new Panel("This is a panel");
            //panel.Header = new PanelHeader("[bold maroon]Header[/]");
            //AnsiConsole.Render(panel);

            //// Correctly formatted bulleted list
            //AnsiConsole.Markup("[blue]\u25A0[/][green] Item 1[/]\n[blue]\u25A0[/][red] Item 2[/]\n[blue]\u25A0[/][red] Item 2[/]\n[blue]\u25A0[/][red] Item 2[/]\n[blue]\u25A0[/][red] Item 2[/]\n\n");

            //var tree = new Tree("[green] Root[/]");

            //// Level 1
            //var branch1 = tree.AddNode("[red] Branch 1[/]");
            //var branch2 = tree.AddNode("[red] Branch 2[/]");

            //// Level 2
            //var subBranch1 = branch1.AddNode("[yellow] Sub-Branch 1.1[/]");
            //var subBranch2 = branch1.AddNode("[yellow] Sub-Branch 1.2[/]");
            //var subBranch3 = branch2.AddNode("[yellow] Sub-Branch 2.1[/]");

            //// Level 3
            //var subSubBranch1 = subBranch1.AddNode("[green] Sub-Sub-Branch 1.1.1[/]");
            //var subSubBranch2 = subBranch1.AddNode("[green] Sub-Sub-Branch 1.1.2[/]");
            //var subSubBranch3 = subBranch2.AddNode("[green] Sub-Sub-Branch 1.2.1[/]");

            //// Level 4
            //var subSubSubBranch1 = subSubBranch1.AddNode("[blue] Sub-Sub-Sub-Branch 1.1.1.1[/]");
            //var subSubSubBranch2 = subSubBranch1.AddNode("[blue] Sub-Sub-Sub-Branch 1.1.1.2[/]");

            //// Level 5
            //var subSubSubSubBranch1 = subSubSubBranch1.AddNode("[red] Sub-Sub-Sub-Sub-Branch 1.1.1.1.1[/]");

            //AnsiConsole.Render(tree);


            //// Render the tree


            //var grid2 = new Grid();

            //// Define columns
            //grid2.AddColumn(new GridColumn().LeftAligned());
            //grid2.AddColumn(new GridColumn().Centered());
            //grid2.AddColumn(new GridColumn().RightAligned());

            //// Add rows with content
            //grid2.AddRow(
            //    new Markup("\n\n\n[bold]Left-aligned text[/]"),
            //    new Markup("[bold yellow]Center-aligned text[/]"),
            //    new Markup("[bold green]Right-aligned text[/]")
            //);

            //grid2.AddRow(
            //    new Markup("Column 1, Row 2"),
            //    new Markup("Column 2, Row 2"),
            //    new Markup("Column 3, Row 2")
            //);

            //// Render the grid
            //AnsiConsole.Render(grid2);


            //var root = new Layout("Root")
            //          .SplitRows(
            //              new Layout("Header").Size(3),
            //              new Layout("Main"),
            //              new Layout("Footer").Size(3));

            //// Split the main section into three columns with proportional sizes
            //root["Main"].SplitColumns(
            //    new Layout("Player Stats").Ratio(1),
            //    new Layout("Game Display").Ratio(2),
            //    new Layout("Inventory").Ratio(1));

            //// Add content to each section
            //root["Header"].Update(new Panel(new Markup("[bold cyan]⚔️ RPG Game Dashboard ⚔️[/]")));

            //root["Main"]["Player Stats"].Update(
            //    new Panel(new Markup("[bold green]Player Stats[/]\n\n"
            //                         + "Level 5 Knight\n"
            //                         + "Health: [red]100[/]/100\n"
            //                         + "Mana: [blue]50[/]/50\n"
            //                         + "XP: 1200/2000")));

            //root["Main"]["Game Display"].Update(
            //    new Panel(new Markup("[bold yellow]Game Display[/]\n\n"
            //                         + "You are in a dark forest, surrounded by towering trees.\n"
            //                         + "To the north, you see a faint light flickering.\n"
            //                         + "What will you do?")));

            //root["Main"]["Inventory"].Update(
            //    new Panel(new Markup("[bold magenta]Inventory[/]\n\n"
            //                         + "- Sword x1\n"
            //                         + "- Shield x1\n"
            //                         + "- Potion x3")));

            //root["Footer"].Update(
            //    new Panel(new Markup("[bold]Message Log[/]\n"
            //                         + "You picked up a potion.\n"
            //                         + "You hear a rustling sound nearby.\n"
            //                         + "The light seems to be getting brighter.")));

            //// Render the layout
            //AnsiConsole.Render(root);



            //var grid3 = new Grid();
            //grid3.AddColumn(); // First column
            //grid3.AddColumn(); // Second column

            //// Create a panel with important information
            //var importantPanel = new Panel(new Markup("[bold red]Important Message![/]\nThis is a critical alert."))
            //    .BorderColor(Color.Red)
            //    .Header("[bold underline]Alert[/]");

            //// Create a panel with general information
            //var infoPanel = new Panel(new Markup("[bold green]Information[/]\nHere is some general information."))
            //    .BorderColor(Color.Green)
            //    .Header("[bold underline]Info[/]");

            //// Use Padder to add padding around the important panel
            //var paddedImportantPanel = new Padder(importantPanel, new Padding(2, 1, 2, 1));

            //// Use Padder to add padding around the information panel
            //var paddedInfoPanel = new Padder(infoPanel, new Padding(2, 1, 2, 1));

            //// Add rows to the grid
            //grid3.AddRow(paddedImportantPanel, paddedInfoPanel);

            //// Render the grid
            //AnsiConsole.Render(grid3);





            //var barChart = new BarChart()
            //       .Width(60) // Set the width of the chart
            //       .Label("[bold yellow]Sales Data 2023[/]") // Add a label to the chart
            //       .CenterLabel(); // Center the label

            //// Add bars to the chart
            //barChart.AddItem("Q1", 30, Color.Green);
            //barChart.AddItem("Q2", 20, Color.Blue);
            //barChart.AddItem("Q3", 50, Color.Blue);
            //barChart.AddItem("Q4", 40, Color.Red);

            //// Add a bar with a bold style (using Color and markup for bold)
            //barChart.AddItem("Total\n\n\n\n\n", 140, Color.Red);

            //// Render the bar chart
            //AnsiConsole.Render(barChart);



            //var options2 = new[] { "Option 1", "Option 2", "Option 3", "Option 4" };

            //// Create a box around the menu
            //Console.WriteLine("┌────────────────────────────────────────────────────┐");
            //Console.WriteLine("│                                                    │");

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("│                  Menu Options:                     │");
            //Console.ResetColor();

            //Console.WriteLine("│                                                    │");

            //for (int i = 0; i < options.Length; i++)
            //{
            //    Console.Write("│  ");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($"{i + 1}. ");
            //    Console.ResetColor();

            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.Write("■");
            //    Console.ResetColor();

            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.Write($" {options[i]}");
            //    Console.ResetColor();

            //    Console.WriteLine(new string(' ', 45 - options[i].Length - 4) + "│");
            //}

            //Console.WriteLine("│                                                    │");

            //Console.Write("│  ");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("Select an option by pressing the corresponding number:");
            //Console.ResetColor();
            //Console.WriteLine("   │");

            //Console.WriteLine("│                                                 │");
            //Console.WriteLine("└─────────────────────────────────────────────────┘");

            //var keyInfo = Console.ReadKey(intercept: true);
            //Console.WriteLine();  // Move to the next line after key press

            //// Validate and process the input
            //if (int.TryParse(keyInfo.KeyChar.ToString(), out int selectedNumber) && selectedNumber >= 1 && selectedNumber <= options.Length)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"You selected: {options[selectedNumber - 1]}");
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Invalid selection. Please run the program again and select a valid option.");
            //    Console.ResetColor();
            //}


            //ProgramStart.start();
            Random random = new Random();

            PracticeCode.switches_Exercise_03();


        }
    }
}
