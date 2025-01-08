using System.Drawing;

namespace PastasCSharpNotesAndExamples
{
    public class Colors
    {
        public static Color defaultColor = Color.FromArgb(242, 168, 39);  //orange color
        public static Color numberColor = Color.FromArgb(255, 255, 255);  //white color
        public static Color lightYellow = Color.FromArgb(219, 203, 96);    //light banana like yellow
        public static Color limeGreen = Color.FromArgb(200, 237, 12);      //lime green color
        public static Color lightPurple = Color.FromArgb(170, 12, 237);
        public static Color salmonOrange = Color.FromArgb(242, 130, 78);
        public static Color blueJayBlue = Color.FromArgb(159, 174, 212);
        public static Color white = Color.FromArgb(255, 255, 255);
        public static Color red = Color.FromArgb(255, 0, 0);
        public static Color lightTeal = Color.FromArgb(20, 255, 251);
        public static Color brightRed = Color.FromArgb(255, 18, 18);
    }

    public static class Helper
    {

        public async static void clearSettings()
        {
            Colorful.Console.ResetColor();
            System.Console.ResetColor();
            System.Console.Clear();
            Colorful.Console.Clear();
            await Task.Delay(500); // Simulating some process

        }

        public static bool isTyping = false;

        public static void writeLine(string text, Color color)
        {
            Colorful.Console.ForegroundColor = color;
            Colorful.Console.WriteLine(text);
        }

        public static void write(string text, Color color)
        {
            Colorful.Console.ForegroundColor = color;
            Colorful.Console.Write(text);
        }

        public static void StopTyping()
        {
            isTyping = false;
        }

    }


 
}