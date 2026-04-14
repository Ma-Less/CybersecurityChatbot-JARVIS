using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play voice greeting
            AudioService.PlayGreeting();

            // Display ASCII art header
            UIHelper.DisplayAsciiArt();

            // Show welcome message
            UIHelper.DisplayWelcomeMessage();

            // Get user's name
            Console.Write(" Please enter your name: ");
            string userName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userName))
            {
                UIHelper.DisplayError(" Name cannot be empty. Please enter your name: ");
                userName = Console.ReadLine();
            }

            // Personalised greeting
            UIHelper.DisplaySuccess($"\n Hello, {userName}! Welcome to JARVIS - Your Cybersecurity Awareness Assistant.");
            UIHelper.DisplayInfo(" I'm here to help you stay safe online.\n");

            // Initialise chatbot
            Chatbot chatbot = new Chatbot(userName);
            chatbot.StartConversation();
        }
    }
}