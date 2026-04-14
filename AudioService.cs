using System;
using System.Media;
using System.IO;
using System.Threading;

namespace CybersecurityChatbot
{
    public static class AudioService
    {
        public static void PlayGreeting()
        {
            string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "greeting.wav");

            if (File.Exists(audioPath))
            {
                try
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync(); // Play synchronously (waits for completion)
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Audio Error] Could not play greeting: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"[Warning] Audio file not found at: {audioPath}");
                Console.WriteLine("Proceeding without voice greeting...");
                Thread.Sleep(1000);
            }
        }
    }
}