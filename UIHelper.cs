using System;
using System.IO;
using System.Threading;

namespace CybersecurityChatbot
{
    public static class UIHelper
    {
        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiArt = @"
    ╔══════════════════════════════════════════════════════════════════╗
    ║                                                                  ║
    ║      ██╗ █████╗ ██████╗ ██╗   ██╗██╗███████╗                     ║
    ║      ██║██╔══██╗██╔══██╗██║   ██║██║██╔════╝                     ║
    ║      ██║███████║██████╔╝██║   ██║██║███████╗                     ║
    ║      ██║██╔══██║██╔══██╗╚██╗ ██╔╝██║╚════██║                     ║
    ║      ██║██║  ██║██║  ██║ ╚████╔╝ ██║███████║                     ║
    ║      ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝  ╚═══╝  ╚═╝╚══════╝                     ║
    ║                                                                  ║
    ║       ██████╗  ██████╗ ████████╗                                 ║
    ║       ██╔══██╗██╔═══██╗╚══██╔══╝                                 ║
    ║       ██████╔╝██║   ██║   ██║                                    ║
    ║       ██╔══██╗██║   ██║   ██║                                    ║
    ║       ██████╔╝╚██████╔╝   ██║                                    ║
    ║       ╚═════╝  ╚═════╝    ╚═╝                                    ║
    ║                                                                  ║
    ║                                                                  ║
    ║              JARVIS - Cybersecurity Awareness Assistant          ║
    ║                     for South Africa                             ║
    ╚══════════════════════════════════════════════════════════════════╝
";
            Console.WriteLine(asciiArt);
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        public static void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + new string('=', 70));
            Console.WriteLine("  WELCOME TO JARVIS - CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("  Your personal guide to staying safe online");
            Console.WriteLine(new string('=', 70));
            Console.ResetColor();
            Thread.Sleep(500);
        }

        public static void DisplayDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('-', 70));
            Console.ResetColor();
        }

        public static void DisplaySuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void DisplayInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DisplayPrompt(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void DisplayBotResponse(string response)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($" JARVIS: {response}");
            Console.ResetColor();
            DisplayDivider();
            Thread.Sleep(300);
        }
    }
}