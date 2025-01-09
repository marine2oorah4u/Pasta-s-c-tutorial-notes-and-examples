using System.Drawing;

namespace PastasCSharpNotesAndExamples
{
    public class ProgramIntro
    {
        public static void Run()
        {
            Helper.isTyping = false;
            System.Threading.Thread.Sleep(500);

            Colorful.Console.ForegroundColor = Color.FromArgb(220, 158, 61); // orange
            Colorful.Console.WriteLine("\n\n\tHello, and welcome to my program!\n");
            System.Threading.Thread.Sleep(500);

            Colorful.Console.ForegroundColor = Color.FromArgb(30, 218, 127); // green

            System.Threading.Thread.Sleep(500);

            string[] intro = new string[]
            {
                "\tThis is a program created to showcase",
                "\tknowledge I've gained and learned,",
                "\tas well as showcasing smaller programs + apps, created to test",
                "\tmy C# knowledge and show my progress",
                "\n\tMy goal is to one day, to prove myself",
                "\tand to join the Total Miner Development team. \n\n",
                "\tI may not be the best at c#, and im continuously learning and imrpoving myself",
                "\tbut I strive to become better each day, however and wherever/whenever possible.",
                "\n\tThank you for checking out my program :)",
                "\n\n\n\tShoutout to the following people for helping me out on my journey and improvement:",
                "\t\t- James",
                "\t\t- Craig",
                "\t\t- Dave the Monitor",
                "\t\t- Paperclip",
                "\t\t- Master L",
                "\t\t- Presley",
                "\t\t- XBLToothPic",
                "\t\t- Native Function",
                "\t\t- the Monogame and c# community Discords",
                "\t\t  as well as other various friendly communities out there",
                "\t\tand many different resources online, such as youtube and other various locations.",
                "\n\n\t\tIf I forgot to credit you, then I apologize",
                "\n\n\n\t\tOtherwise Thank you to everyone who has helped me,",
                "\t\tand for those who will Continually help me along my path or journey",
                "\t\tof becoming a c# developer.",
                "\n\n\n\t\tThank You :)"
            };

            Color[] introColors = new Color[]
            {
                //need 26 colors
                Colors.deepBlue,
                Colors.defaultColor,
                Colors.goldenYellow,
                Colors.salmonOrange,
                Colors.peach,
                Colors.defaultColor,
                Colors.goldenYellow,
                Colors.lightTeal,
                Colors.brightRed,
                Colors.peach,
                Colors.lightPurple,
                Colors.lightTeal,
                Colors.defaultColor,
                Colors.salmonOrange,
                Colors.peach,
                //
                Colors.lightPurple,
                Colors.blueJayBlue,
                Colors.defaultColor,
                Colors.lightYellow,
                Colors.peach,
                Colors.yellowGreen,
                Colors.defaultColor,
                Colors.lightYellow,
                Colors.salmonOrange,
                Colors.mintGreen,
                Colors.defaultColor
/*
 *     {
public static Color defaultColor = Color.FromArgb(242, 168, 39);  // orange color
public static Color numberColor = Color.FromArgb(255, 255, 255);  // white color
public static Color lightYellow = Color.FromArgb(219, 203, 96);    // light banana like yellow
public static Color limeGreen = Color.FromArgb(200, 237, 12);      // lime green color
public static Color lightPurple = Color.FromArgb(170, 12, 237);
public static Color salmonOrange = Color.FromArgb(242, 130, 78);
public static Color blueJayBlue = Color.FromArgb(159, 174, 212);
public static Color white = Color.FromArgb(255, 255, 255);
public static Color red = Color.FromArgb(255, 0, 0);
public static Color lightTeal = Color.FromArgb(20, 255, 251);
public static Color brightRed = Color.FromArgb(255, 18, 18);
public static Color deepBlue = Color.FromArgb(0, 0, 255);
public static Color forestGreen = Color.FromArgb(34, 139, 34);
public static Color goldenYellow = Color.FromArgb(255, 215, 0);
public static Color lavender = Color.FromArgb(230, 190, 255);
public static Color mintGreen = Color.FromArgb(0, 255, 150);
public static Color navyBlue = Color.FromArgb(0, 0, 128);
public static Color pink = Color.FromArgb(255, 105, 180);
public static Color powderBlue = Color.FromArgb(176, 224, 230);
public static Color royalBlue = Color.FromArgb(65, 105, 225);
public static Color silver = Color.FromArgb(192, 192, 192);
public static Color turquoise = Color.FromArgb(0, 191, 255);
public static Color coral = Color.FromArgb(255, 127, 80);
public static Color skyBlue = Color.FromArgb(135, 206, 235);
public static Color magenta = Color.FromArgb(255, 0, 255);
public static Color peach = Color.FromArgb(255, 229, 180);
public static Color seaGreen = Color.FromArgb(46, 139, 87);
public static Color slateGray = Color.FromArgb(112, 128, 144);
public static Color springGreen = Color.FromArgb(0, 255, 127);
public static Color steelBlue = Color.FromArgb(70, 130, 180);
public static Color tan = Color.FromArgb(210, 180, 140);
public static Color thistle = Color.FromArgb(216, 191, 216);
public static Color violet = Color.FromArgb(238, 84, 144);
public static Color wheat = Color.FromArgb(245, 222, 179);
public static Color yellowGreen = Color.FromArgb(154, 205, 50);
*/



};

int delayBetweenLines = 20; // 200ms delay between lines

for (int i = 0; i < intro.Length; i++)
{
Colorful.Console.ForegroundColor = introColors[i % introColors.Length];
TypeOutMessage(intro[i], 10);
Colorful.Console.WriteLine();
System.Threading.Thread.Sleep(delayBetweenLines);
}
System.Threading.Thread.Sleep(1000);

static void TypeOutMessage(string message, int delay)
{
int index = 0;
Helper.isTyping = true;

while (Helper.isTyping)
{
    if (System.Console.KeyAvailable)
    {
        if (System.Console.KeyAvailable)
            System.Console.ReadKey(true); // Consume the key press
        Helper.isTyping = false;

        // Print the remaining characters
        while (index < message.Length)
        {
            Colorful.Console.Write(message[index]);
            index++;
        }

        Colorful.Console.WriteLine();
        Colorful.Console.WriteLine("Press any key to continue...");
        System.Console.ReadKey(true);
        return; // Return to prevent further execution
    }

    if (index < message.Length)
    {
        Colorful.Console.Write(message[index]);
        index++;
        System.Threading.Thread.Sleep(delay);
    }
    else
    {
        Helper.isTyping = false; // Ensure this properly stops the loop
    }
}
}
}
}
}
