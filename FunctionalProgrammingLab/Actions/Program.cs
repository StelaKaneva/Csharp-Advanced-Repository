using System;

namespace Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> logger = LogInfo; // logger сочи към LogInfo

            logger("Pesho");

            Action noParamsLogger = LogInfoNoParams;
            noParamsLogger();
        }

        static void LogInfo(string name)
        {
            Console.WriteLine($"Say my name {name}");
        }

        static void LogInfoNoParams()
        {
            Console.WriteLine($"Say my name");
        }
    }
}
