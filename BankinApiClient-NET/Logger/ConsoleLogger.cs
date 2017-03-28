using System;
using System.Runtime.CompilerServices;

namespace BankinApi.Client.Logger
{
    public class ConsoleLogger : ILogAdapter
    {
        private void Log(string message, [CallerMemberName] string caller = null)
        {
            Console.WriteLine(caller.ToUpper() + " - " + message);
        }

        public void Warn(string message)
        {
            Log(message);
        }

        public void Debug(string message) { }

        public void Trace(string debug) { }
    }
}