using System.Drawing;

namespace PastasCSharpNotesAndExamples
{
    public static class Colors
    {
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

        public static object Convert { get; internal set; }

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

        public static void WriteLine(string text, Color color)
        {
            Colorful.Console.ForegroundColor = color;
            Colorful.Console.WriteLine(text);
        }

        public static void StopTyping()
        {
            isTyping = false;
        }

 
    }
}