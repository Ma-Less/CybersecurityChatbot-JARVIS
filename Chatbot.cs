using System;
using System.Collections.Generic;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private string userName;
        private string botName = "JARVIS";
        private Dictionary<string, string[]> responseMap;
        private Random random;

        public Chatbot(string name)
        {
            userName = name;
            random = new Random();
            InitializeResponses();
        }

        private void InitializeResponses()
        {
            responseMap = new Dictionary<string, string[]>
            {
                { "how are you", new[] { $"I'm doing great, {userName}! Thanks for asking. How can JARVIS help you today?", "All systems secure and operational! Ready to share cybersecurity tips with you.", "Functioning perfectly! What can I assist you with?" } },
                { "purpose", new[] { $"My name is JARVIS. My purpose is to educate South Africans about cybersecurity and help you stay safe online from threats like phishing, scams, and malware.", "JARVIS is here to help you learn about online safety and protect yourself from cyber threats." } },
                { "what can i ask", new[] { "You can ask JARVIS about: password safety, phishing scams, safe browsing habits, or just chat with me!", "Feel free to ask about cybersecurity topics like password safety, phishing, or safe browsing." } },
                { "password", new[] { $"{userName}, use strong, unique passwords for each account. Avoid personal info like your name or birthday. Consider using a password manager!", "A good password should be at least 12 characters long with a mix of letters, numbers, and symbols. Never share it with anyone!" } },
                { "phish", new[] { $"{userName}, phishing scams try to trick you into giving away personal info. Never click suspicious links or download attachments from unknown senders.", "Always verify the sender's email address. Legitimate companies won't ask for your password via email!" } },
                { "safe browsing", new[] { "Look for 'https://' and a padlock icon in the address bar before entering personal info. Avoid using public Wi-Fi for banking.", "Keep your browser updated, use ad blockers, and never save passwords on shared computers." } },
                { "help", new[] { $"JARVIS can help with password safety, phishing scams, and safe browsing habits. Just ask me a question, {userName}!", "Type your question or say 'exit' to quit." } },
                { "who are you", new[] { $"I am JARVIS - Just A Rather Very Intelligent System. Your cybersecurity awareness assistant!", "JARVIS, at your service! I'm here to help you stay safe online." } },
                { "jarvis", new[] { "That's me! JARVIS reporting for duty. How can I help you today?", "Yes, I'm JARVIS. Ready to assist with cybersecurity awareness!" } }
            };
        }

        public string GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return $"{userName}, I didn't catch that. Could you please say something?";
            }

            string lowerInput = input.ToLower();

            // Check for exit command
            if (lowerInput == "exit" || lowerInput == "quit" || lowerInput == "goodbye" || lowerInput == "bye")
            {
                return $"Stay safe online, {userName}! JARVIS signing off. Goodbye!";
            }

            // Check each keyword
            foreach (var kvp in responseMap)
            {
                if (lowerInput.Contains(kvp.Key))
                {
                    string[] responses = kvp.Value;
                    return responses[random.Next(responses.Length)];
                }
            }

            // Default response for unrecognised input
            return $"I didn't quite understand that, {userName}. Could you rephrase? You can ask JARVIS about password safety, phishing, or safe browsing.";
        }

        public void StartConversation()
        {
            UIHelper.DisplayDivider();
            UIHelper.DisplayInfo($" JARVIS: Type your questions below. Type 'exit' to quit.\n");

            while (true)
            {
                UIHelper.DisplayPrompt($"{userName}: ");
                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    UIHelper.DisplayError($" Please enter a valid question, {userName}.\n");
                    continue;
                }

                string response = GetResponse(userInput);

                // Check if exit
                if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit" || userInput.ToLower() == "goodbye" || userInput.ToLower() == "bye")
                {
                    UIHelper.DisplaySuccess($"\n JARVIS: {response}\n");
                    UIHelper.DisplayDivider();
                    break;
                }

                UIHelper.DisplayBotResponse(response);
            }
        }
    }
}
