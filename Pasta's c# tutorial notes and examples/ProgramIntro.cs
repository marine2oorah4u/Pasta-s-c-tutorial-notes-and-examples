using System.Drawing;
using Colorful;
using System;

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
                Colors.lightYellow,
                Colors.limeGreen,
                Colors.blueJayBlue,
                Colors.salmonOrange,
                Colors.defaultColor,
                Colors.coral,
                Colors.red,
                Colors.lightTeal,
                Colors.salmonOrange,
                Colors.lightYellow,
                Colors.defaultColor,
                Colors.deepBlue,
                Colors.forestGreen,
                Colors.goldenYellow,
                Colors.lavender,
                Colors.mintGreen,
                Colors.navyBlue,
                Colors.pink,
                Colors.powderBlue,
                Colors.royalBlue,
                Colors.silver,
                Colors.turquoise,
                Colors.brightRed,
                Colors.white,
                Colors.numberColor,
                Colors.lightPurple,
                Colors.skyBlue,
                Colors.magenta,
                Colors.peach,
                Colors.yellowGreen, // Added more colors to ensure coverage
                Colors.thistle,
                Colors.tan,
                Colors.springGreen
            };

            int delayBetweenLines = 200; // 200ms delay between lines

            for (int i = 0; i < intro.Length; i++)
            {
                Colorful.Console.ForegroundColor = introColors[i % introColors.Length];
                TypeOutMessage(intro[i], 40);
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
