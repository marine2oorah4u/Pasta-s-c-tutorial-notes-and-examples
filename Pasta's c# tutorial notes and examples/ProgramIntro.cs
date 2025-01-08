using System;
using System.Drawing;
using System.Security.Cryptography;

namespace PastasCSharpNotesAndExamples
{
    public class ProgramIntro
    {
        public static void Run()
        {
            Helper.isTyping = false;

            Colorful.Console.ForegroundColor = Color.FromArgb(220, 158, 61); // orange
            Colorful.Console.WriteLine("\tHello, and welcome to my program!\n");
            Thread.Sleep(100);

            Colorful.Console.ForegroundColor = Color.FromArgb(30, 218, 127); // green
            Colorful.Console.WriteLine("\tThis is a program created to showcase\n\t" +
                                 "knowledge I've gained and short or\n\t" +
                                 "smaller programs + apps," +
                                 "created to test\n\t" +
                                 "my C# knowledge and show my progress\n\n\t" +
                                 "My goal is to one day, to prove myself\n\t" +
                                 "and to join the Total Miner Developer \n\n");
            Thread.Sleep(100);

            Colorful.Console.ForegroundColor = Color.FromArgb(190, 143, 70);
            Colorful.Console.WriteLine("\tPress any key to continue.");

            string message = "Hello, this is typed out one character at a time!";
            TypeOutMessage(message, 50);
        }

        static void TypeOutMessage(string message, int delay)
        {
            int index = 0;
            Helper.isTyping = true;

            while (Helper.isTyping)
            {
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true); // Consume the key press
                    Helper.isTyping = false;

                    // Print the remaining characters
                    while (index < message.Length)
                    {
                        Console.Write(message[index]);
                        index++;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey(true);
                    Console.Clear();
                    ProgramStart.start();
                    return;
                }

                if (index < message.Length)
                {
                    Console.Write(message[index]);
                    index++;
                    System.Threading.Thread.Sleep(delay);
                }
            }
        }
    }
}
