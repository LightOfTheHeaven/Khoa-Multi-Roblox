using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "KHOA MULTI";

            // Intro
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\r\n  \r\n ___  __    ___  ___  ________  ________          _____ ______   ___  ___  ___   _________  ___     \r\n|\\  \\|\\  \\ |\\  \\|\\  \\|\\   __  \\|\\   __  \\        |\\   _ \\  _   \\|\\  \\|\\  \\|\\  \\ |\\___   ___\\\\  \\    \r\n\\ \\  \\/  /|\\ \\  \\\\\\  \\ \\  \\|\\  \\ \\  \\|\\  \\       \\ \\  \\\\\\__\\ \\  \\ \\  \\\\\\  \\ \\  \\\\|___ \\  \\_\\ \\  \\   \r\n \\ \\   ___  \\ \\   __  \\ \\  \\\\\\  \\ \\   __  \\       \\ \\  \\\\|__| \\  \\ \\  \\\\\\  \\ \\  \\    \\ \\  \\ \\ \\  \\  \r\n  \\ \\  \\\\ \\  \\ \\  \\ \\  \\ \\  \\\\\\  \\ \\  \\ \\  \\       \\ \\  \\    \\ \\  \\ \\  \\\\\\  \\ \\  \\____\\ \\  \\ \\ \\  \\ \r\n   \\ \\__\\\\ \\__\\ \\__\\ \\__\\ \\_______\\ \\__\\ \\__\\       \\ \\__\\    \\ \\__\\ \\_______\\ \\_______\\ \\__\\ \\ \\__\\\r\n    \\|__| \\|__|\\|__|\\|__|\\|_______|\\|__|\\|__|        \\|__|     \\|__|\\|_______|\\|_______|\\|__|  \\|__|\r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n\r\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nMade by Khoa\n\n");
            
            // Note 
            Console.Write("=== Note ===\nPlease make sure that you ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("run this ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("before running Roblox or it will not work! You must use seperate accounts.\nIf you close this window, all Roblox instances will close except for one.\n\n");
            
            // Actual thing
            new Mutex(true, "ROBLOX_singletonMutex");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Multiple Roblox Instances is now running!\n");

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write("\nDo not press enter or this application will close.");
            //Console.ReadLine();
            Thread.Sleep(-1); //Keeps Application Open Until Closed By User

        }
    }
}
