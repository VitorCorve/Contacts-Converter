using System.Collections.Generic;

namespace DataConverter.Service
{
    public class ErrorsHandler
    {
        public static List<string> Errors { get; } = new List<string>();
        public static void Handle(string message) => Errors.Add(message);
    }
}
