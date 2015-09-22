using System;

namespace PokeD.ServerProxy.Desktop
{
    public static partial class Program
    {
        private static void ExecuteCommand(string message)
        {
            var command = message.Remove(0, 1).ToLower();
            message = message.Remove(0, 1);

            if (message.StartsWith("stop"))
            {
                Proxy.Stop();
                ConsoleManager.WriteLine("Stopped the server. Press Enter to continue.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else if (message.StartsWith("clear"))
                ConsoleManager.Clear();
        }
    }
}
