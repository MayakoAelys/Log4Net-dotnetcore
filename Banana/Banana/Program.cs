using System;
using Banana.Toolbox.Logger;

namespace Banana
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.LogIn();

            var exception = 
                new Exception("Example exception",
                    new Exception("Example inner exception",
                        new Exception("Example inner exception 2")));

            Logger.Log("Message from the main program"); // Will be debug (as default)
            Logger.Log("Test INFO level", LogType.Info);
            Logger.Log("Test WARN level", LogType.Warn);
            Logger.Log("Test ERROR level", LogType.Error);
            Logger.Log("Test FATAL level", LogType.Fatal);

            Logger.LogException(exception);

            Logger.LogOut();
        }
    }
}
